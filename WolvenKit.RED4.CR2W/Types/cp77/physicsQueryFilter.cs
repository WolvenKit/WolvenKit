using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsQueryFilter : CVariable
	{
		private CUInt64 _mask1;
		private CUInt64 _mask2;

		[Ordinal(0)] 
		[RED("mask1")] 
		public CUInt64 Mask1
		{
			get
			{
				if (_mask1 == null)
				{
					_mask1 = (CUInt64) CR2WTypeManager.Create("Uint64", "mask1", cr2w, this);
				}
				return _mask1;
			}
			set
			{
				if (_mask1 == value)
				{
					return;
				}
				_mask1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("mask2")] 
		public CUInt64 Mask2
		{
			get
			{
				if (_mask2 == null)
				{
					_mask2 = (CUInt64) CR2WTypeManager.Create("Uint64", "mask2", cr2w, this);
				}
				return _mask2;
			}
			set
			{
				if (_mask2 == value)
				{
					return;
				}
				_mask2 = value;
				PropertySet(this);
			}
		}

		public physicsQueryFilter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
