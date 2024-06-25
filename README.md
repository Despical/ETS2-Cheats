<h1 align="center">ETS 2 Cheats</h1>

<div align="center">

A console application that modifies money and exp amounts of a ETS 2 profile by manipulating the memory.
</div>

> [!NOTE]  
> Preferably, use .NET 7 or later to run this program.<br>
> It may still function with older versions, but compatibility is not guaranteed.

## Pointer Table
| v1.50.1.0s<br>64-bit  | **Address**  | **Offsets** |
| :-----: | :-----:    | :------:     |
| Money   | 0x029E20C0 | [0x10, 0x10] |
| Exp     | 0x029E20C0 | [0x196C]     |

> [!IMPORTANT]  
> Datas in this table is only compatible with **ETS 2 v1.50.1.0s** and **64-bit**.

## Donations
- [Buy Me A Coffee](https://www.buymeacoffee.com/despical)

## License
This code is under [GPL-3.0 License](http://www.gnu.org/licenses/gpl-3.0.html)

See the [LICENSE](https://github.com/Despical/ETS2-Cheats/blob/main/LICENSE) file for required notices and attributions.

## Libraries Used
* [Swed64](https://github.com/Massivetwat/Swed64) - Makes ReadProcessMemory and WriteProcessMemory easier for C#.
