using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkCompositionTransition : CVariable
	{
		private CName _targetState;
		private CArray<inkCompositionInterpolator> _interpolators;

		[Ordinal(0)] 
		[RED("targetState")] 
		public CName TargetState
		{
			get
			{
				if (_targetState == null)
				{
					_targetState = (CName) CR2WTypeManager.Create("CName", "targetState", cr2w, this);
				}
				return _targetState;
			}
			set
			{
				if (_targetState == value)
				{
					return;
				}
				_targetState = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("interpolators")] 
		public CArray<inkCompositionInterpolator> Interpolators
		{
			get
			{
				if (_interpolators == null)
				{
					_interpolators = (CArray<inkCompositionInterpolator>) CR2WTypeManager.Create("array:inkCompositionInterpolator", "interpolators", cr2w, this);
				}
				return _interpolators;
			}
			set
			{
				if (_interpolators == value)
				{
					return;
				}
				_interpolators = value;
				PropertySet(this);
			}
		}

		public inkCompositionTransition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
