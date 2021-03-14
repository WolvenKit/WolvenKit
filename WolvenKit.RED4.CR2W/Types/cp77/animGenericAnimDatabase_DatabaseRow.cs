using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animGenericAnimDatabase_DatabaseRow : CVariable
	{
		private CArray<CInt32> _inputValues;
		private animGenericAnimDatabase_AnimationData _animationData;

		[Ordinal(0)] 
		[RED("inputValues")] 
		public CArray<CInt32> InputValues
		{
			get
			{
				if (_inputValues == null)
				{
					_inputValues = (CArray<CInt32>) CR2WTypeManager.Create("array:Int32", "inputValues", cr2w, this);
				}
				return _inputValues;
			}
			set
			{
				if (_inputValues == value)
				{
					return;
				}
				_inputValues = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("animationData")] 
		public animGenericAnimDatabase_AnimationData AnimationData
		{
			get
			{
				if (_animationData == null)
				{
					_animationData = (animGenericAnimDatabase_AnimationData) CR2WTypeManager.Create("animGenericAnimDatabase_AnimationData", "animationData", cr2w, this);
				}
				return _animationData;
			}
			set
			{
				if (_animationData == value)
				{
					return;
				}
				_animationData = value;
				PropertySet(this);
			}
		}

		public animGenericAnimDatabase_DatabaseRow(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
