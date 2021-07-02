window.scrollToElement = (elementId) => {
    let element = document.getElementById(elementId)
    console.log('aa', element)

    if (element) {
        element.scrollIntoView({ behavior: 'smooth' })
    }
}