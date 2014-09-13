function play(n) {

	t = ['zero','one','two','three','four','five','six','seven','eight','nine'];
	a = (n + '').split('')
	r = ' '
	for (i = 0; i < a.length; i++) {
		r += t[a[i]] + ' '
	return r.trim()
}
console.log(play(123));
