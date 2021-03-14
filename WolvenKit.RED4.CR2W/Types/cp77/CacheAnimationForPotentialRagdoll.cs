using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CacheAnimationForPotentialRagdoll : RagdollTask
	{
		private CName _currentBehavior;

		[Ordinal(0)] 
		[RED("currentBehavior")] 
		public CName CurrentBehavior
		{
			get
			{
				if (_currentBehavior == null)
				{
					_currentBehavior = (CName) CR2WTypeManager.Create("CName", "currentBehavior", cr2w, this);
				}
				return _currentBehavior;
			}
			set
			{
				if (_currentBehavior == value)
				{
					return;
				}
				_currentBehavior = value;
				PropertySet(this);
			}
		}

		public CacheAnimationForPotentialRagdoll(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
