using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animActionAnimDatabase_DatabaseRow : CVariable
	{
		private CName _animFeatureName;
		private CInt32 _state;
		private CInt32 _animVariation;
		private animActionAnimDatabase_AnimationData _animationData;

		[Ordinal(0)] 
		[RED("animFeatureName")] 
		public CName AnimFeatureName
		{
			get
			{
				if (_animFeatureName == null)
				{
					_animFeatureName = (CName) CR2WTypeManager.Create("CName", "animFeatureName", cr2w, this);
				}
				return _animFeatureName;
			}
			set
			{
				if (_animFeatureName == value)
				{
					return;
				}
				_animFeatureName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("state")] 
		public CInt32 State
		{
			get
			{
				if (_state == null)
				{
					_state = (CInt32) CR2WTypeManager.Create("Int32", "state", cr2w, this);
				}
				return _state;
			}
			set
			{
				if (_state == value)
				{
					return;
				}
				_state = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("animVariation")] 
		public CInt32 AnimVariation
		{
			get
			{
				if (_animVariation == null)
				{
					_animVariation = (CInt32) CR2WTypeManager.Create("Int32", "animVariation", cr2w, this);
				}
				return _animVariation;
			}
			set
			{
				if (_animVariation == value)
				{
					return;
				}
				_animVariation = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("animationData")] 
		public animActionAnimDatabase_AnimationData AnimationData
		{
			get
			{
				if (_animationData == null)
				{
					_animationData = (animActionAnimDatabase_AnimationData) CR2WTypeManager.Create("animActionAnimDatabase_AnimationData", "animationData", cr2w, this);
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

		public animActionAnimDatabase_DatabaseRow(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
