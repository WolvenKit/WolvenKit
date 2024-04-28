using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ReactiveUI;
using WolvenKit.App.ViewModels.Tools;
using WolvenKit.Common.FNV1A;
using WolvenKit.Core.CRC;
using WolvenKit.Core.Murmur3;
using WolvenKit.RED4.Types;
using WolvenKit.RED4.Types.Pools;
using YamlDotNet.Core.Tokens;

namespace WolvenKit.Views.Tools;
/// <summary>
/// Interaktionslogik für HasherView.xaml
/// </summary>
public partial class HashToolView : ReactiveUserControl<HashToolViewModel>
{
    public HashToolView()
    {
        InitializeComponent();
    }

    private void InputTextBox_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        var cNameHash = FNV1A64HashAlgorithm.HashString(InputTextBox.Text);
        CNameHash.SetCurrentValue(TextBox.TextProperty, cNameHash.ToString());
        CNameHashHex.SetCurrentValue(TextBox.TextProperty, $"0x{cNameHash:X16}");

        var depotHash = ResourcePath.CalculateHash(InputTextBox.Text);
        DepotHash.SetCurrentValue(TextBox.TextProperty, depotHash.ToString());
        DepotHashHex.SetCurrentValue(TextBox.TextProperty, $"0x{depotHash:X16}");

        var nodeRefHash = FNV1A64HashAlgorithm.HashString(InputTextBox.Text.Replace("#", ""));
        NodeRefHash.SetCurrentValue(TextBox.TextProperty, nodeRefHash.ToString());
        NodeRefHashHex.SetCurrentValue(TextBox.TextProperty, $"0x{nodeRefHash:X16}");

        var tweakDbId = Crc32Algorithm.Compute(InputTextBox.Text) + ((ulong)InputTextBox.Text.Length << 32);
        TweakDbIdHash.SetCurrentValue(TextBox.TextProperty, tweakDbId.ToString());
        TweakDbIdHashHex.SetCurrentValue(TextBox.TextProperty, $"0x{tweakDbId:X16}");

        var murmur3 = Murmur32.Hash(InputTextBox.Text, 0x5EEDBA5E);
        Murmur3Hash.SetCurrentValue(TextBox.TextProperty, murmur3.ToString());
        Murmur3HashHex.SetCurrentValue(TextBox.TextProperty, $"0x{murmur3:X8}");
    }

    private void NumberTextBox_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        ulong hash;

        var text = NumberTextBox.Text;
        if (text.StartsWith("0x"))
        {
            text = text[2..];
        }

        if (!ulong.TryParse(text, out hash) && 
            !ulong.TryParse(text, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out hash))
        {
            return;
        }

        CNameTextBox.SetCurrentValue(TextBox.TextProperty, CNamePool.ResolveHash(hash));
        DepotTextBox.SetCurrentValue(TextBox.TextProperty, ResourcePathPool.ResolveHash(hash));
        NodeRefTextBox.SetCurrentValue(TextBox.TextProperty, NodeRefPool.ResolveHash(hash));
        TweakDbIdTextBox.SetCurrentValue(TextBox.TextProperty, TweakDBIDPool.ResolveHash(hash));
    }
}
