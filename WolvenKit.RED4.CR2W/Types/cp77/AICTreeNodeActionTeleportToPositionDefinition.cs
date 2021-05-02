using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AICTreeNodeActionTeleportToPositionDefinition : AICTreeNodeActionDefinition
	{
		private CName _positionName;
		private CBool _doNavTest;

		[Ordinal(1)] 
		[RED("positionName")] 
		public CName PositionName
		{
			get => GetProperty(ref _positionName);
			set => SetProperty(ref _positionName, value);
		}

		[Ordinal(2)] 
		[RED("doNavTest")] 
		public CBool DoNavTest
		{
			get => GetProperty(ref _doNavTest);
			set => SetProperty(ref _doNavTest, value);
		}

		public AICTreeNodeActionTeleportToPositionDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
