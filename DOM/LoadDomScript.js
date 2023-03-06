String.prototype.capitalize = function () {
    return this.charAt(0).toUpperCase() + this.substr(1);
}


function LightenDarkenColor(col, amt) {

    var usePound = false;

    if (col[0] == "#") {
        col = col.slice(1);
        usePound = true;
    }

    var num = parseInt(col, 16);

    var r = (num >> 16) + amt;

    if (r > 255) r = 255;
    else if (r <= 0) r = 0;

    var b = ((num >> 8) & 0x00FF) + amt;

    if (b > 255) b = 255;
    else if (b <= 0) b = 0;

    var g = (num & 0x0000FF) + amt;

    if (g > 255) g = 255;
    else if (g <= 0) g = 0;

    return (usePound ? "#" : "") + String("000000" + (g | (b << 8) | (r << 16)).toString(16)).slice(-6);

}


const setStyleBoot = theme => {

    let scrollBoot = `
    :root{
        --scroll-thumb-color: ${LightenDarkenColor(theme.primary, 20) };
        --scroll-back-color: ${LightenDarkenColor(theme.primary, -80)};
    }
    ::-webkit-scrollbar {
        background: var(--scroll-back-color);
    }
    ::-webkit-scrollbar-thumb {
        background: var(--scroll-thumb-color);
        border: var(--scroll-back-color) solid 6px;
        border-radius: 13px;
    }
    `;
    let style = document.createElement('style');
    style.id = "mx-style";
    style.innerHTML = scrollBoot;
    document.head.appendChild(style);
}



const MX_BROWSER = {
    theme: {},
    Application: {},
    onTheme: theme => { },
    onStatus: status => { },
    getApplication({ theme, ...props }) {
        window.dispatchEvent(new Event('onTheme'));
        MX_BROWSER.onTheme(theme);
        MX_BROWSER.theme = theme;
        window.dispatchEvent(new Event('onStatus'));
        MX_BROWSER.onStatus(props);
        MX_BROWSER.Application = props;
        setStyleBoot(theme); 
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

