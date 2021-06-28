using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questPauseTime_NodeType : questITimeManagerNodeType
	{
		private CBool _pause;
		private CName _source;

		[Ordinal(0)] 
		[RED("pause")] 
		public CBool Pause
		{
			get => GetProperty(ref _pause);
			set => SetProperty(ref _pause, value);
		}

		[Ordinal(1)] 
		[RED("source")] 
		public CName Source
		{
			get => GetProperty(ref _source);
			set => SetProperty(ref _source, value);
		}

		public questPauseTime_NodeType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
