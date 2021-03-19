using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class netPeerID : CVariable
	{
		private CUInt8 _value;

		[Ordinal(0)] 
		[RED("value")] 
		public CUInt8 Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		public netPeerID(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
