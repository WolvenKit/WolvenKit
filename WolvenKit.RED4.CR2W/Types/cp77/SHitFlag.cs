using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SHitFlag : CVariable
	{
		private CEnum<hitFlag> _flag;
		private CName _source;

		[Ordinal(0)] 
		[RED("flag")] 
		public CEnum<hitFlag> Flag
		{
			get => GetProperty(ref _flag);
			set => SetProperty(ref _flag, value);
		}

		[Ordinal(1)] 
		[RED("source")] 
		public CName Source
		{
			get => GetProperty(ref _source);
			set => SetProperty(ref _source, value);
		}

		public SHitFlag(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
