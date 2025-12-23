// reCAPTCHA JavaScript interop for Blazor
window.recaptcha = {
    widgetId: null,
    onSuccessCallback: null,
    onExpiredCallback: null,
    onErrorCallback: null,

    init: function (containerId, siteKey) {
        return new Promise((resolve, reject) => {
            try {
                // Wait for grecaptcha to be available
                if (typeof grecaptcha === 'undefined') {
                    setTimeout(() => {
                        this.init(containerId, siteKey).then(resolve).catch(reject);
                    }, 100);
                    return;
                }

                const container = document.getElementById(containerId);
                if (!container) {
                    reject(new Error('reCAPTCHA container not found'));
                    return;
                }

                // Render reCAPTCHA widget
                this.widgetId = grecaptcha.render(container, {
                    'sitekey': siteKey,
                    'callback': (response) => {
                        if (this.onSuccessCallback) {
                            this.onSuccessCallback.invokeMethodAsync('OnCaptchaSuccess', response);
                        }
                    },
                    'expired-callback': () => {
                        if (this.onExpiredCallback) {
                            this.onExpiredCallback.invokeMethodAsync('OnCaptchaExpired');
                        }
                    },
                    'error-callback': () => {
                        if (this.onErrorCallback) {
                            this.onErrorCallback.invokeMethodAsync('OnCaptchaError');
                        }
                    }
                });

                resolve(this.widgetId);
            } catch (error) {
                reject(error);
            }
        });
    },

    onSuccess: function (widgetId, dotNetRef) {
        this.onSuccessCallback = dotNetRef;
        this.onExpiredCallback = dotNetRef;
        this.onErrorCallback = dotNetRef;
    },

    reset: function (widgetId) {
        if (typeof grecaptcha !== 'undefined' && widgetId !== null) {
            grecaptcha.reset(widgetId);
        }
    },

    getResponse: function (widgetId) {
        if (typeof grecaptcha !== 'undefined' && widgetId !== null) {
            return grecaptcha.getResponse(widgetId);
        }
        return null;
    }
};

