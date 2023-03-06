String.prototype.capitalize = function () {
    return this.charAt(0).toUpperCase() + this.substr(1);
}

const MX_BROWSER = {
    theme: {},
    getTheme(theme) {
        window.dispatchEvent(new Event('start:theme'));
        MX_BROWSER.theme = theme;
    },
    onClose: ()=> true,
    onMinimize() {
        window.dispatchEvent(new Event('onMinimize'));
    },
    onMaximize() {
        window.dispatchEvent(new Event('onMaximize'));
    },
    onNormalize() {
        window.dispatchEvent(new Event('onNormalize'));
    },
    onMouseMove() {
        window.dispatchEvent(new Event('onMouseMove'));
    },
    onMouseDown() {
        window.dispatchEvent(new Event('onMouseDown'));
    },
    onMouseUp() {
        window.dispatchEvent(new Event('onMouseUp'));
    },
    close() {
        MX_BROWSER.dispatchAction('close');
    },
    minimize() {
        MX_BROWSER.dispatchAction('minimize');
    },
    maximize() {
        MX_BROWSER.dispatchAction('maximize');
    },
    dispatchAction: (method, params = null) => {

        const api = {
            method: `Window_${method.capitalize()}`,
            parameters: params
        }
        const query = new URLSearchParams(api).toString();
        const call = "#api?" + query;
        location.href = call;
        location.href = "#";
    },

}

