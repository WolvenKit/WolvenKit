using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectPostAction_Beam_RicochetPreview : gameEffectPostAction
	{
		private gameEffectPostAction_Beam_RicochetPreviewPreviewEffect _ricocheted;
		private gameEffectPostAction_Beam_RicochetPreviewPreviewEffect _fromMuzzle;

		[Ordinal(0)] 
		[RED("ricocheted")] 
		public gameEffectPostAction_Beam_RicochetPreviewPreviewEffect Ricocheted
		{
			get
			{
				if (_ricocheted == null)
				{
					_ricocheted = (gameEffectPostAction_Beam_RicochetPreviewPreviewEffect) CR2WTypeManager.Create("gameEffectPostAction_Beam_RicochetPreviewPreviewEffect", "ricocheted", cr2w, this);
				}
				return _ricocheted;
			}
			set
			{
				if (_ricocheted == value)
				{
					return;
				}
				_ricocheted = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("fromMuzzle")] 
		public gameEffectPostAction_Beam_RicochetPreviewPreviewEffect FromMuzzle
		{
			get
			{
				if (_fromMuzzle == null)
				{
					_fromMuzzle = (gameEffectPostAction_Beam_RicochetPreviewPreviewEffect) CR2WTypeManager.Create("gameEffectPostAction_Beam_RicochetPreviewPreviewEffect", "fromMuzzle", cr2w, this);
				}
				return _fromMuzzle;
			}
			set
			{
				if (_fromMuzzle == value)
				{
					return;
				}
				_fromMuzzle = value;
				PropertySet(this);
			}
		}

		public gameEffectPostAction_Beam_RicochetPreview(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
