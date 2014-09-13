function play(n) {

	r = ''

	for (i = 0; i < n.length; i++) {

		c = n.charCodeAt(i)
		x = c + 13

		x = (c < 91 && x > 90) || ((x > 90 && x < 97) || x > 122) ? x-26 : x

		r += String.fromCharCode(x)
	}
	return r
}
//console.log(play('abcdefghABCDEFGH'));