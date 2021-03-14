using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_OwnerType : animAnimFeature
	{
		private CInt32 _ownerEnum;

		[Ordinal(0)] 
		[RED("ownerEnum")] 
		public CInt32 OwnerEnum
		{
			get
			{
				if (_ownerEnum == null)
				{
					_ownerEnum = (CInt32) CR2WTypeManager.Create("Int32", "ownerEnum", cr2w, this);
				}
				return _ownerEnum;
			}
			set
			{
				if (_ownerEnum == value)
				{
					return;
				}
				_ownerEnum = value;
				PropertySet(this);
			}
		}

		public AnimFeature_OwnerType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
