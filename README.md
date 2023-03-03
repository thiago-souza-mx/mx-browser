# Api de Eventos

Para interceptar eventos é preciso iniciar um objeto {**Window**} e declarar os métodos que deseja usar.

### Eventos

|  Name | Type  | Decription   |
| :------------ | :------------ | :------------ |
| **onClose()** | *function, bool, async* |  Ao fechar aplicação, espera um **true**  |
| **onMinimize()** | *function, void* |  Ao minimizar  |
|**onMaximize()** | *function, void* |  Ao maximizar (**full Screen**)  |
|**onNormalize()** | *function, void* |  Ao Restaurar de minimizado ou maximizado  |
|**onMouseMove()** | *function, void* |  Ao Mover o mouse sobre a ToolBar |
|**onMouseDown()** | *function, void* |  Ao Clicar Sobre a ToolBar |
|**onMouseUp()**  | *function, void* |  Ao finalizar o click sobre a ToolBar |

### Example code:
Neste exemplo de código declaramos os métodos e escrevemos na `<div id="message"></div>`  sempre que um método é chamado.

```html
<html>
<body>
    <div id="message"></div>
    <script>
        const drawText = text => document.getElementById("message").innerText = text;
        const Window = {
            onClose() {
                let text = "Press a button!\nEither OK or Cancel.";
                return confirm(text)
            },
            onMinimize() {
                drawText('onMinimize')
            },
            onMaximize() {
                drawText('onMaximize')
            },
            onNormalize() {
                drawText('onNormalize')
            },
            onMouseMove() {
                drawText('onMouseMove')
            },
            onMouseDown() {
                drawText('onMouseDown')
            },
            onMouseUp() {
                drawText('onMouseUp')
            }
        }
    </script>
</body>
</html>
```
