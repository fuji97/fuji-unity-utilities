[![npm package](https://img.shields.io/npm/v/com.fuji97.fuji-unity-utilities)](https://www.npmjs.com/package/com.fuji97.fuji-unity-utilities)
[![openupm](https://img.shields.io/npm/v/com.fuji97.fuji-unity-utilities?label=openupm&registry_uri=https://package.openupm.com)](https://openupm.com/packages/com.fuji97.fuji-unity-utilities/)
![Tests](https://github.com/fuji97/fuji-unity-utilities/workflows/Tests/badge.svg)
[![License: MIT](https://img.shields.io/badge/License-MIT-green.svg)](https://opensource.org/licenses/MIT)

# Fuji's Unity Utilities

Fuji's Unity Utilities

- [Fuji's Unity Utilities](#fujis-unity-utilities)
  - [Dependencies](#dependencies)
  - [How to use](#how-to-use)
  - [Install](#install)
    - [via npm](#via-npm)
    - [via OpenUPM](#via-openupm)
    - [via Git URL](#via-git-url)
  - [Configuration](#configuration)
  - [License](#license)

<!-- toc -->

## Dependencies
- [Cysharp/UniTask](https://github.com/Cysharp/UniTask)
- [Demigiant/dotween](https://github.com/Demigiant/dotween)

## How to use

*Work In Progress*

## Install

### via npm

Open `Packages/manifest.json` with your favorite text editor. Add a [scoped registry](https://docs.unity3d.com/Manual/upm-scoped.html) and following line to dependencies block:
```json
{
  "scopedRegistries": [
    {
      "name": "npmjs",
      "url": "https://registry.npmjs.org/",
      "scopes": [
        "com.fuji97"
      ]
    }
  ],
  "dependencies": {
    "com.fuji97.fuji-unity-utilities": "1.0.0"
  }
}
```
Package should now appear in package manager.

### via OpenUPM

The package is also available on the [openupm registry](https://openupm.com/packages/com.fuji97.fuji-unity-utilities). You can install it eg. via [openupm-cli](https://github.com/openupm/openupm-cli).

```
openupm add com.fuji97.fuji-unity-utilities
```

### via Git URL

Open `Packages/manifest.json` with your favorite text editor. Add following line to the dependencies block:
```json
{
  "dependencies": {
    "com.fuji97.fuji-unity-utilities": "https://github.com/fuji97/fuji-unity-utilities.git",
    "com.cysharp.unitask": "https://github.com/Cysharp/UniTask.git?path=src/UniTask/Assets/Plugins/UniTask",
    "com.demigiant.dotween": "https://github.com/yoshida190/dotween"
  }
}
```

## Configuration

*Work In Progress*

## License

MIT License

Copyright © 2022 Federico Rapetti (fuji97)