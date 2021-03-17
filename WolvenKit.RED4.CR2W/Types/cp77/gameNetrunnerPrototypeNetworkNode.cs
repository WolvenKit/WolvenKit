using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameNetrunnerPrototypeNetworkNode : gameObject
	{
		private CInt8 _colorIndex;

		[Ordinal(40)] 
		[RED("colorIndex")] 
		public CInt8 ColorIndex
		{
			get => GetProperty(ref _colorIndex);
			set => SetProperty(ref _colorIndex, value);
		}

		public gameNetrunnerPrototypeNetworkNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
