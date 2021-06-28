using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class senseIShape : IScriptable
	{
		private TweakDBID _id;

		[Ordinal(0)] 
		[RED("id")] 
		public TweakDBID Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		public senseIShape(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
