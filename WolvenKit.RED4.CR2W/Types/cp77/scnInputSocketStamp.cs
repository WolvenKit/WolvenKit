using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnInputSocketStamp : CVariable
	{
		private CUInt16 _name;
		private CUInt16 _ordinal;

		[Ordinal(0)] 
		[RED("name")] 
		public CUInt16 Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("ordinal")] 
		public CUInt16 Ordinal
		{
			get => GetProperty(ref _ordinal);
			set => SetProperty(ref _ordinal, value);
		}

		public scnInputSocketStamp(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
