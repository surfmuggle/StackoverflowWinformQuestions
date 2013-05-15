function toggleChangelog(ev) {
	if (ev.target.parentNode.id == "show") {
		document.getElementById('old').removeAttribute('style'); 
		document.getElementById('hide').removeAttribute('style'); 
		document.getElementById('show').setAttribute('style', 'display:none');
	}
	else {
		document.getElementById('old').setAttribute('style', 'display:none');
		document.getElementById('show').removeAttribute('style'); 	
		document.getElementById('hide').setAttribute('style', 'display:none');
	}		
}
