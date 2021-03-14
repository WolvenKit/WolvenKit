using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_FacialReaction : animAnimFeature
	{
		private CInt32 _category;
		private CInt32 _idle;

		[Ordinal(0)] 
		[RED("category")] 
		public CInt32 Category
		{
			get
			{
				if (_category == null)
				{
					_category = (CInt32) CR2WTypeManager.Create("Int32", "category", cr2w, this);
				}
				return _category;
			}
			set
			{
				if (_category == value)
				{
					return;
				}
				_category = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("idle")] 
		public CInt32 Idle
		{
			get
			{
				if (_idle == null)
				{
					_idle = (CInt32) CR2WTypeManager.Create("Int32", "idle", cr2w, this);
				}
				return _idle;
			}
			set
			{
				if (_idle == value)
				{
					return;
				}
				_idle = value;
				PropertySet(this);
			}
		}

		public AnimFeature_FacialReaction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
