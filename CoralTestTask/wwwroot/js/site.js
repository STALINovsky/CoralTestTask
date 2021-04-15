var currentTab = 0; 
showTab(currentTab); 


function showTab(index) {
    
    let currentTab = document.getElementsByClassName("tab");
    currentTab[index].style.display = "block";

    let previousBtnDisplayStyle;
    if (index === 0) {
        previousBtnDisplayStyle = "none";
    } else {
        previousBtnDisplayStyle = "inline";
    }
    document.getElementById("prevBtn").style.display = previousBtnDisplayStyle;

    let nextBtnText = index === (currentTab.length - 1) ? "Submit" : "Next";
    document.getElementById("nextBtn").innerHTML = nextBtnText;
  
    updateStepIndicator(index)
}



function shift(offset) {

    let tabs = document.getElementsByClassName("tab");
    
    if (offset === 1 && !validateForm()) return false;
    
    tabs[currentTab].style.display = "none";
    
    currentTab = currentTab + offset;
    
    if (currentTab >= tabs.length) {
        
        document.getElementById("regForm").submit();
        return false;
    }
    
    showTab(currentTab);
}

function validateForm() {
    return $("#regForm").data('unobtrusiveValidation').validate();; // return the valid status
}

function updateStepIndicator(n) {
    
    let i, x = document.getElementsByClassName("step");
    for (i = 0; i < x.length; i++) {
        x[i].className = x[i].className.replace(" active", "");
    }
    
    x[n].className += " active";
}