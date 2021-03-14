using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkTweakDBIDSelector : IScriptable
	{
		private TweakDBID _baseTweakID;

		[Ordinal(0)] 
		[RED("baseTweakID")] 
		public TweakDBID BaseTweakID
		{
			get
			{
				if (_baseTweakID == null)
				{
					_baseTweakID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "baseTweakID", cr2w, this);
				}
				return _baseTweakID;
			}
			set
			{
				if (_baseTweakID == value)
				{
					return;
				}
				_baseTweakID = value;
				PropertySet(this);
			}
		}

		public inkTweakDBIDSelector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
