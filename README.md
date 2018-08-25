# Greekum Ipsum CLI 📝

> Generate random greek paragraphs, sentences & more.

[![npm version](https://badge.fury.io/js/greekumipsum-cli.svg)](https://badge.fury.io/js/greekumipsum-cli) 
[![XO code style](https://img.shields.io/badge/code_style-XO-5ed9c7.svg)](https://github.com/xojs/xo) 
[![npm license](https://img.shields.io/npm/l/greekumipsum-cli.svg)](https://opensource.org/licenses/MIT)


[![NPM](https://nodei.co/npm/greekumipsum-cli.png?downloads=true&downloadRank=true&stars=true)](https://nodei.co/npm/greekumipsum-cli/)

[![asciicast](https://asciinema.org/a/197970.png)](https://asciinema.org/a/197970)

| CLI (Node.js)     | Original (Bridge) | Original (C#)     | Tests (Node.JS)   | Tests (C#)        |
|-------------------|-------------------|-------------------|-------------------|-------------------|
| [![Build 1](https://travis-matrix-badges.herokuapp.com/repos/xxczaki/greekumipsum-cli/branches/master/1)](https://travis-ci.org/xxczaki/greekumipsum-cli) | [![Build 2](https://travis-matrix-badges.herokuapp.com/repos/xxczaki/greekumipsum-cli/branches/master/2)](https://travis-ci.org/xxczaki/greekumipsum-cli) | [![Build 3](https://travis-matrix-badges.herokuapp.com/repos/xxczaki/greekumipsum-cli/branches/master/3)](https://travis-ci.org/xxczaki/greekumipsum-cli) | ![Travis (.org) branch](https://img.shields.io/travis/xxczaki/greekumipsum-cli/tests.svg?label=tests) | ![Travis (.org) branch](https://img.shields.io/travis/xxczaki/greekumipsum-cli/tests.svg?label=tests) |

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

## Maintainers

[![Antoni Kepinski](https://github.com/xxczaki.png?size=100)](https://kepinski.me) | [![Krzysztof Szewczyk](https://github.com/KrzysztofSzewczyk.png?size=100)](https://github.com/KrzysztofSzewczyk)
---|---
[Antoni Kepinski](https://kepinski.me) | [Krzysztof Szewczyk](https://github.com/KrzysztofSzewczyk)

## License

MIT
