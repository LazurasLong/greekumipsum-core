# Greekum Ipsum CLI 📝

> Generate random greek paragraphs, sentences & more.

[![XO code style](https://img.shields.io/badge/code_style-XO-5ed9c7.svg)](https://github.com/xojs/xo) [![npm version](https://badge.fury.io/js/greekumipsum-cli.svg)](https://badge.fury.io/js/greekumipsum-cli) ![NpmLicense](https://img.shields.io/npm/l/greekumipsum-cli.svg)

| CLI (Node.js)     | Original (Bridge) | Original (C#)     |
|-------------------|-------------------|-------------------|
| [![Build 1](https://travis-matrix-badges.herokuapp.com/repos/xxczaki/greekumipsum-cli/branches/master/1)](https://travis-ci.org/xxczaki/greekumipsum-cli) | [![Build 2](https://travis-matrix-badges.herokuapp.com/repos/xxczaki/greekumipsum-cli/branches/master/2)](https://travis-ci.org/xxczaki/greekumipsum-cli) | [![Build 3](https://travis-matrix-badges.herokuapp.com/repos/xxczaki/greekumipsum-cli/branches/master/3)](https://travis-ci.org/xxczaki/greekumipsum-cli)

# What is Greekum Ipsum?
Original description:

> Greekum Ipsum is variation of Lorem Ipsum. It was made by [Krzysztof Szewczyk](https://github.com/KrzysztofSzewczyk), serving same purpose as Lorem Ipsum, with another feature - creating generators of this, or even trying it out in applications or websites, can test system's capability to render unicode characters.

# Install
```bash
npm install --global greekumipsum-cli
```

You can also use the [online generator](https://krzysztofszewczyk.github.io/MiscStuff/greekum/)!

# Usage

```bash
Usage
 $ greekum <option> <number>

Options
 -p --paragraph  Generate paragraph
 -w --word       Generate word
 -s --sentence   Generate sentence
 -c --character  Generate character
 -h --help       Display help message

Examples
 $ greekum --paragraph 5
 $ greekum -c 3
```
## Note
This CLI app is just a simple wrapper around the original Greekum Ipsum script, made by my friend [Krzysztof Szewczyk](https://github.com/KrzysztofSzewczyk). 
All credit should go to him 😄

## License

MIT
