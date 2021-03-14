using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameStoryTierChangedEvent : AIAIEvent
	{
		private CEnum<gameStoryTier> _newTier;

		[Ordinal(2)] 
		[RED("newTier")] 
		public CEnum<gameStoryTier> NewTier
		{
			get
			{
				if (_newTier == null)
				{
					_newTier = (CEnum<gameStoryTier>) CR2WTypeManager.Create("gameStoryTier", "newTier", cr2w, this);
				}
				return _newTier;
			}
			set
			{
				if (_newTier == value)
				{
					return;
				}
				_newTier = value;
				PropertySet(this);
			}
		}

		public gameStoryTierChangedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
