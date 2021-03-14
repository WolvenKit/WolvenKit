using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameContainerObjectBase : gameLootContainerBase
	{
		private TweakDBID _lockedByKey;

		[Ordinal(50)] 
		[RED("lockedByKey")] 
		public TweakDBID LockedByKey
		{
			get
			{
				if (_lockedByKey == null)
				{
					_lockedByKey = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "lockedByKey", cr2w, this);
				}
				return _lockedByKey;
			}
			set
			{
				if (_lockedByKey == value)
				{
					return;
				}
				_lockedByKey = value;
				PropertySet(this);
			}
		}

		public gameContainerObjectBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
