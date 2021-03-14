using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnDialogLineEvent : scnSceneEvent
	{
		private scnscreenplayItemId _screenplayLineId;
		private scnDialogLineVoParams _voParams;
		private CEnum<scnDialogLineVisualStyle> _visualStyle;
		private scnAdditionalSpeakers _additionalSpeakers;

		[Ordinal(6)] 
		[RED("screenplayLineId")] 
		public scnscreenplayItemId ScreenplayLineId
		{
			get
			{
				if (_screenplayLineId == null)
				{
					_screenplayLineId = (scnscreenplayItemId) CR2WTypeManager.Create("scnscreenplayItemId", "screenplayLineId", cr2w, this);
				}
				return _screenplayLineId;
			}
			set
			{
				if (_screenplayLineId == value)
				{
					return;
				}
				_screenplayLineId = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("voParams")] 
		public scnDialogLineVoParams VoParams
		{
			get
			{
				if (_voParams == null)
				{
					_voParams = (scnDialogLineVoParams) CR2WTypeManager.Create("scnDialogLineVoParams", "voParams", cr2w, this);
				}
				return _voParams;
			}
			set
			{
				if (_voParams == value)
				{
					return;
				}
				_voParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("visualStyle")] 
		public CEnum<scnDialogLineVisualStyle> VisualStyle
		{
			get
			{
				if (_visualStyle == null)
				{
					_visualStyle = (CEnum<scnDialogLineVisualStyle>) CR2WTypeManager.Create("scnDialogLineVisualStyle", "visualStyle", cr2w, this);
				}
				return _visualStyle;
			}
			set
			{
				if (_visualStyle == value)
				{
					return;
				}
				_visualStyle = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("additionalSpeakers")] 
		public scnAdditionalSpeakers AdditionalSpeakers
		{
			get
			{
				if (_additionalSpeakers == null)
				{
					_additionalSpeakers = (scnAdditionalSpeakers) CR2WTypeManager.Create("scnAdditionalSpeakers", "additionalSpeakers", cr2w, this);
				}
				return _additionalSpeakers;
			}
			set
			{
				if (_additionalSpeakers == value)
				{
					return;
				}
				_additionalSpeakers = value;
				PropertySet(this);
			}
		}

		public scnDialogLineEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
