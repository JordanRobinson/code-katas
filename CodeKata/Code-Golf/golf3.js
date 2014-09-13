function play() {

v = [["We're no strangers to love",
"You know the rules and so do I",
"A full commitment's what I'm thinking of",
"You wouldn't get this from any other guy",
"I just wanna tell you how I'm feeling",
"Gotta make you understand",
""]
,
["We've known each other for so long",
"Your heart's been aching but",
"You're too shy to say it",
"Inside we both know what's been going on",
"We know the game and we're gonna play it",
"And if you ask me how I'm feeling",
"Don't tell me you're too blind to see",
""]
,
["(Ooh, give you up)",
"(Ooh, give you up)",
"(Ooh)",
"Never gonna give, never gonna give",
"(Give you up)",
"(Ooh)",
"Never gonna give, never gonna give",
"(Give you up)",
"",
"We've know each other for so long",
"Your heart's been aching but",
"You're too shy to say it",
"Inside we both know what's been going on",
"We know the game and we're gonna play it",
"",
"I just wanna tell you how I'm feeling",
"Gotta make you understand",
""]];

 c= 
["Never gonna give you up",
"Never gonna let you down",
"Never gonna run around and desert you",
"Never gonna make you cry",
"Never gonna say goodbye",
"Never gonna tell a lie and hurt you",
""]

	return [v[0].join(),c,v[1].join(),c,c,v[2].join(),c,c,c].join('\n');
}
console.log(play())