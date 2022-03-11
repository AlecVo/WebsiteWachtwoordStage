/* Toggle between adding and removing the "responsive" class to topnav when the user clicks on the icon */
function myFunction() {
  var x = document.getElementById("navbar");
  if (x.className === "flex-container-item") {
    x.className += " responsive";
  } else {
    x.className = "flex-container-item";
  }
}