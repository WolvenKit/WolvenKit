using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectObjectFilter_HitRepresentation_Raycast : gameEffectObjectFilter_HitRepresentation
	{
		private CBool _isPreview;

		[Ordinal(0)] 
		[RED("isPreview")] 
		public CBool IsPreview
		{
			get
			{
				if (_isPreview == null)
				{
					_isPreview = (CBool) CR2WTypeManager.Create("Bool", "isPreview", cr2w, this);
				}
				return _isPreview;
			}
			set
			{
				if (_isPreview == value)
				{
					return;
				}
				_isPreview = value;
				PropertySet(this);
			}
		}

		public gameEffectObjectFilter_HitRepresentation_Raycast(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
