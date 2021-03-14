using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_PhotomodePoseCategory : animAnimFeature
	{
		private CInt32 _poseCategoryIndex;

		[Ordinal(0)] 
		[RED("poseCategoryIndex")] 
		public CInt32 PoseCategoryIndex
		{
			get
			{
				if (_poseCategoryIndex == null)
				{
					_poseCategoryIndex = (CInt32) CR2WTypeManager.Create("Int32", "poseCategoryIndex", cr2w, this);
				}
				return _poseCategoryIndex;
			}
			set
			{
				if (_poseCategoryIndex == value)
				{
					return;
				}
				_poseCategoryIndex = value;
				PropertySet(this);
			}
		}

		public AnimFeature_PhotomodePoseCategory(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
