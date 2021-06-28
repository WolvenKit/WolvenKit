using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questContentLock_ConditionType : questIContentConditionType
	{
		private CBool _isContentBlocked;

		[Ordinal(0)] 
		[RED("isContentBlocked")] 
		public CBool IsContentBlocked
		{
			get => GetProperty(ref _isContentBlocked);
			set => SetProperty(ref _isContentBlocked, value);
		}

		public questContentLock_ConditionType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
