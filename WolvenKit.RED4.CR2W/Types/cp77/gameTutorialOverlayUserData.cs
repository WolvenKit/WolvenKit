using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTutorialOverlayUserData : inkUserData
	{
		private CBool _hideOnInput;
		private CUInt32 _overlayId;

		[Ordinal(0)] 
		[RED("hideOnInput")] 
		public CBool HideOnInput
		{
			get
			{
				if (_hideOnInput == null)
				{
					_hideOnInput = (CBool) CR2WTypeManager.Create("Bool", "hideOnInput", cr2w, this);
				}
				return _hideOnInput;
			}
			set
			{
				if (_hideOnInput == value)
				{
					return;
				}
				_hideOnInput = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("overlayId")] 
		public CUInt32 OverlayId
		{
			get
			{
				if (_overlayId == null)
				{
					_overlayId = (CUInt32) CR2WTypeManager.Create("Uint32", "overlayId", cr2w, this);
				}
				return _overlayId;
			}
			set
			{
				if (_overlayId == value)
				{
					return;
				}
				_overlayId = value;
				PropertySet(this);
			}
		}

		public gameTutorialOverlayUserData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
