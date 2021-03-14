using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameprojectileProjectilePreviewEvent : gameprojectileSpawnerPreviewEvent
	{
		private Transform _visualOffset;

		[Ordinal(1)] 
		[RED("visualOffset")] 
		public Transform VisualOffset
		{
			get
			{
				if (_visualOffset == null)
				{
					_visualOffset = (Transform) CR2WTypeManager.Create("Transform", "visualOffset", cr2w, this);
				}
				return _visualOffset;
			}
			set
			{
				if (_visualOffset == value)
				{
					return;
				}
				_visualOffset = value;
				PropertySet(this);
			}
		}

		public gameprojectileProjectilePreviewEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
