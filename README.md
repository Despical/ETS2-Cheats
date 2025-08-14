<h1 align="center">ETS 2 Cheats</h1>

<div align="center">

A console application that modifies money and exp amounts of a ETS 2 profile by manipulating the memory.
</div>

> [!NOTE]  
> Preferably, use .NET 7 or later to run this program.<br>
> It may still function with older versions, but compatibility is not guaranteed.

## Pointer Table
| v1.55.1.5s<br>64-bit  | **Address**  | **Offsets** |
| :-----: | :-----:    | :------:     |
| Money   | 0x02A88DA8 | [0x10, 0x10] |
| Exp     | 0x02A88DA8 | [0x196C]     |

**Special thanks to [@Walter](https://github.com/walter-exit) for providing the updated values
— check out [this issue](https://github.com/Despical/ETS2-Cheats/issues/1) for a more detailed explanation.**

> [!IMPORTANT]  
> Datas in this table is only compatible with **ETS 2 v1.55.1.5s** and **64-bit**.

## Donations
- [Buy Me A Coffee](https://www.buymeacoffee.com/despical)

## License
This code is under [GPL-3.0 License](http://www.gnu.org/licenses/gpl-3.0.html)

See the [LICENSE](https://github.com/Despical/ETS2-Cheats/blob/main/LICENSE) file for required notices and attributions.

## Libraries Used
* [Swed64](https://github.com/Massivetwat/Swed64) - Makes ReadProcessMemory and WriteProcessMemory easier for C#.
