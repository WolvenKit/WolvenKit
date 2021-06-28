using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimTransformMappingEntry : CVariable
	{
		private CName _from;
		private CName _to;

		[Ordinal(0)] 
		[RED("from")] 
		public CName From
		{
			get => GetProperty(ref _from);
			set => SetProperty(ref _from, value);
		}

		[Ordinal(1)] 
		[RED("to")] 
		public CName To
		{
			get => GetProperty(ref _to);
			set => SetProperty(ref _to, value);
		}

		public animAnimTransformMappingEntry(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
