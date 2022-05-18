const button = document.querySelector('input');
const p1 = document.querySelector('p1');

button.addEventListener('click', updateButton);

function updateButton() {
  if (button.value === 'enter') {
    button.value = 'Enter';
    paragraph.textContent = 'Enter!';
  } 
}