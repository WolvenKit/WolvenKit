using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class KnockdownReactionTask : AIHitReactionTask
	{
		private TweakDBID _tweakDBPackage;

		[Ordinal(4)] 
		[RED("tweakDBPackage")] 
		public TweakDBID TweakDBPackage
		{
			get
			{
				if (_tweakDBPackage == null)
				{
					_tweakDBPackage = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "tweakDBPackage", cr2w, this);
				}
				return _tweakDBPackage;
			}
			set
			{
				if (_tweakDBPackage == value)
				{
					return;
				}
				_tweakDBPackage = value;
				PropertySet(this);
			}
		}

		public KnockdownReactionTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
