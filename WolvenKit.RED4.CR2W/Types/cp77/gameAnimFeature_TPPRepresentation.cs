using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameAnimFeature_TPPRepresentation : animAnimFeature
	{
		private CBool _isActive;

		[Ordinal(0)] 
		[RED("IsActive")] 
		public CBool IsActive
		{
			get
			{
				if (_isActive == null)
				{
					_isActive = (CBool) CR2WTypeManager.Create("Bool", "IsActive", cr2w, this);
				}
				return _isActive;
			}
			set
			{
				if (_isActive == value)
				{
					return;
				}
				_isActive = value;
				PropertySet(this);
			}
		}

		public gameAnimFeature_TPPRepresentation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
