<p align="center">
  <img src="Hope.Ethereum.PRPS/Hope_Background.png?raw=true" alt="Hope" align="center" width="785px" height="328px"/>
</p>

| Code Quality |
| :----|
| [![CodeFactor][0]][1] |

[0]: https://www.codefactor.io/repository/github/hopewallet/hope.ethereum.prps/badge
[1]: https://www.codefactor.io/repository/github/hopewallet/hope.ethereum.prps

# Hope.Ethereum.PRPS

.NET class library which allows for interaction with PRPS (Purpose) and DUBI (Decentralized Universal Basic Income).

Includes standard .NET functioning library as well as a Unity game engine compliant library. 

## Installation

Since the Hope.Ethereum.PRPS library is split up into two core libraries, the installation is slightly different for the two.

### .NET Standard Library

The required dlls for the Standard Library to function are located in the [Hope.Ethereum.PRPS releases](https://github.com/HopeWallet/Hope.Ethereum.PRPS/releases). Download the latest Hope.Ethereum.PRPS zip file, and add all required dlls to your project reference.

### Unity Library

The required dlls for the Unity Library to function are located in the [Hope.Ethereum.PRPS releases](https://github.com/HopeWallet/Hope.Ethereum.PRPS/releases). Download the latest Hope.Ethereum.Unity.PRPS zip file, and add all required dlls to your Unity project's plugins folder.

### Dependencies

The Hope.Ethereum.PRPS library has dependencies on the following libraries: [Nethereum](https://github.com/Nethereum/Nethereum) and [Hope.Ethereum](https://github.com/HopeWallet/Hope.Ethereum). 

If you already have any of these libraries imported, only add the Hope.Ethereum.PRPS or Hope.Ethereum.Unity.PRPS dll. If not, they are included in each release.
