using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_PhotomodeFacial : animAnimFeature
	{
		private CInt32 _facialPoseIndex;

		[Ordinal(0)] 
		[RED("facialPoseIndex")] 
		public CInt32 FacialPoseIndex
		{
			get
			{
				if (_facialPoseIndex == null)
				{
					_facialPoseIndex = (CInt32) CR2WTypeManager.Create("Int32", "facialPoseIndex", cr2w, this);
				}
				return _facialPoseIndex;
			}
			set
			{
				if (_facialPoseIndex == value)
				{
					return;
				}
				_facialPoseIndex = value;
				PropertySet(this);
			}
		}

		public AnimFeature_PhotomodeFacial(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
