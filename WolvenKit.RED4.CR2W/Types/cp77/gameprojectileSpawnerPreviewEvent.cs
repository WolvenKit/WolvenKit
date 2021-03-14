using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameprojectileSpawnerPreviewEvent : redEvent
	{
		private CBool _previewActive;

		[Ordinal(0)] 
		[RED("previewActive")] 
		public CBool PreviewActive
		{
			get
			{
				if (_previewActive == null)
				{
					_previewActive = (CBool) CR2WTypeManager.Create("Bool", "previewActive", cr2w, this);
				}
				return _previewActive;
			}
			set
			{
				if (_previewActive == value)
				{
					return;
				}
				_previewActive = value;
				PropertySet(this);
			}
		}

		public gameprojectileSpawnerPreviewEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
