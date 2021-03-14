using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_StimReactions : animAnimFeature
	{
		private CInt32 _reactionType;

		[Ordinal(0)] 
		[RED("reactionType")] 
		public CInt32 ReactionType
		{
			get
			{
				if (_reactionType == null)
				{
					_reactionType = (CInt32) CR2WTypeManager.Create("Int32", "reactionType", cr2w, this);
				}
				return _reactionType;
			}
			set
			{
				if (_reactionType == value)
				{
					return;
				}
				_reactionType = value;
				PropertySet(this);
			}
		}

		public AnimFeature_StimReactions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
