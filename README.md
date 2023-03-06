# Api de Eventos

Para interceptar eventos é preciso iniciar um objeto {**MX_BROWSER**} e declarar os métodos que deseja usar.

### Eventos

|  Name | Type  | Decription   |
| :------------ | :------------ | :------------ |
| **onClose()** | *function, bool, async* |  Ao fechar aplicação, espera um **true**  |
| **onReload()** | *function, bool, async* |  Ao fechar aplicação, espera um **true**  |
| **onMinimize()** | *function, void* |  Ao minimizar  |
|**onMaximize()** | *function, void* |  Ao maximizar (**full Screen**)  |
|**onNormalize()** | *function, void* |  Ao Restaurar de minimizado ou maximizado  |
|**onMouseMove()** | *function, void* |  Ao Mover o mouse sobre a ToolBar |
|**onMouseDown()** | *function, void* |  Ao Clicar Sobre a ToolBar |
|**onMouseUp()**  | *function, void* |  Ao finalizar o click sobre a ToolBar |
|**onTheme(theme)**  | *function, void* |  Ao Carregar a página, envia o objeto |
|**onStatus(theme)**  | *function, void* |  Devolve o status da janela Minimized/Normal/Maximized |


### Métodos
|  Name | Type  | Decription   |
| :------------ | :------------ | :------------ |
| **close()** | *function* |  Solicita o fechamento da aplicação |
| **reload()** | *function* |  Solicita o releoad da aplicação. Esse evento retorna a aplicação para a pagina inicial |
| **minimize()** | *function* | minimiza a janela do app  |
| **maximize()** | *function, toggle* |  Se o estado é normal, maximiza, do contrario, restaura ao normal  |

### TEMA
Um objeto recebido contendo os seguintes parametros:

- **primary** : Cor primária da aplicação
- **secondary** : Cor secundária da aplicação


### Example code:
Neste exemplo de código declaramos os métodos e escrevemos na `<div id="message"></div>`  sempre que um método é chamado.

```html
<html>
<body>
    <div id="message"></div>
    <script>
        const drawText = text => document.getElementById("message").innerText = text;
        MX_BROWSER.onClose = ()=> {
            let text = "Press a button!\nEither OK or Cancel.";
            return confirm(text)
        }
        MX_BROWSER.onMinimize = ()=> {
            drawText('onMinimize')
        }
        MX_BROWSER.onMaximize = ()=> {
            drawText('onMaximize')
        }
        MX_BROWSER.onNormalize = ()=> {
            drawText('onNormalize')
        }
        MX_BROWSER.onMouseMove = ()=> {
            drawText('onMouseMove')
        }
        MX_BROWSER.onMouseDown = ()=> {
            drawText('onMouseDown')
        }
        MX_BROWSER.onMouseUp = ()=>  {
            drawText('onMouseUp')
        }

    </script>
</body>
</html>
```
