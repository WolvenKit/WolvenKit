using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FilterTargetsByDistanceFromRoot : gameEffectObjectSingleFilter_Scripted
	{
		private CFloat _rootOffset_Z;
		private CFloat _tollerance;

		[Ordinal(0)] 
		[RED("rootOffset_Z")] 
		public CFloat RootOffset_Z
		{
			get
			{
				if (_rootOffset_Z == null)
				{
					_rootOffset_Z = (CFloat) CR2WTypeManager.Create("Float", "rootOffset_Z", cr2w, this);
				}
				return _rootOffset_Z;
			}
			set
			{
				if (_rootOffset_Z == value)
				{
					return;
				}
				_rootOffset_Z = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("tollerance")] 
		public CFloat Tollerance
		{
			get
			{
				if (_tollerance == null)
				{
					_tollerance = (CFloat) CR2WTypeManager.Create("Float", "tollerance", cr2w, this);
				}
				return _tollerance;
			}
			set
			{
				if (_tollerance == value)
				{
					return;
				}
				_tollerance = value;
				PropertySet(this);
			}
		}

		public FilterTargetsByDistanceFromRoot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
