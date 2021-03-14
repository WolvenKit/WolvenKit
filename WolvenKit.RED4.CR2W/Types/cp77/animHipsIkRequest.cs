using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animHipsIkRequest : CVariable
	{
		private CName _leftLegIkChain;
		private CName _rightLegIkChain;
		private animTransformIndex _hipsTransformIndex;
		private animTransformIndex _leftFootTransformIndex;
		private animTransformIndex _rightFootTransformIndex;

		[Ordinal(0)] 
		[RED("leftLegIkChain")] 
		public CName LeftLegIkChain
		{
			get
			{
				if (_leftLegIkChain == null)
				{
					_leftLegIkChain = (CName) CR2WTypeManager.Create("CName", "leftLegIkChain", cr2w, this);
				}
				return _leftLegIkChain;
			}
			set
			{
				if (_leftLegIkChain == value)
				{
					return;
				}
				_leftLegIkChain = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("rightLegIkChain")] 
		public CName RightLegIkChain
		{
			get
			{
				if (_rightLegIkChain == null)
				{
					_rightLegIkChain = (CName) CR2WTypeManager.Create("CName", "rightLegIkChain", cr2w, this);
				}
				return _rightLegIkChain;
			}
			set
			{
				if (_rightLegIkChain == value)
				{
					return;
				}
				_rightLegIkChain = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("hipsTransformIndex")] 
		public animTransformIndex HipsTransformIndex
		{
			get
			{
				if (_hipsTransformIndex == null)
				{
					_hipsTransformIndex = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "hipsTransformIndex", cr2w, this);
				}
				return _hipsTransformIndex;
			}
			set
			{
				if (_hipsTransformIndex == value)
				{
					return;
				}
				_hipsTransformIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("leftFootTransformIndex")] 
		public animTransformIndex LeftFootTransformIndex
		{
			get
			{
				if (_leftFootTransformIndex == null)
				{
					_leftFootTransformIndex = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "leftFootTransformIndex", cr2w, this);
				}
				return _leftFootTransformIndex;
			}
			set
			{
				if (_leftFootTransformIndex == value)
				{
					return;
				}
				_leftFootTransformIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("rightFootTransformIndex")] 
		public animTransformIndex RightFootTransformIndex
		{
			get
			{
				if (_rightFootTransformIndex == null)
				{
					_rightFootTransformIndex = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "rightFootTransformIndex", cr2w, this);
				}
				return _rightFootTransformIndex;
			}
			set
			{
				if (_rightFootTransformIndex == value)
				{
					return;
				}
				_rightFootTransformIndex = value;
				PropertySet(this);
			}
		}

		public animHipsIkRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
