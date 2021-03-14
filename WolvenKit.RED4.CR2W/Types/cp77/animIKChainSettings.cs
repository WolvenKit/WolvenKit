using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animIKChainSettings : CVariable
	{
		private CName _chainName;
		private CName _enableFloatTrack;
		private Vector3 _ikEndPointOffset;
		private Quaternion _ikEndRotationOffset;

		[Ordinal(0)] 
		[RED("chainName")] 
		public CName ChainName
		{
			get
			{
				if (_chainName == null)
				{
					_chainName = (CName) CR2WTypeManager.Create("CName", "chainName", cr2w, this);
				}
				return _chainName;
			}
			set
			{
				if (_chainName == value)
				{
					return;
				}
				_chainName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("enableFloatTrack")] 
		public CName EnableFloatTrack
		{
			get
			{
				if (_enableFloatTrack == null)
				{
					_enableFloatTrack = (CName) CR2WTypeManager.Create("CName", "enableFloatTrack", cr2w, this);
				}
				return _enableFloatTrack;
			}
			set
			{
				if (_enableFloatTrack == value)
				{
					return;
				}
				_enableFloatTrack = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("ikEndPointOffset")] 
		public Vector3 IkEndPointOffset
		{
			get
			{
				if (_ikEndPointOffset == null)
				{
					_ikEndPointOffset = (Vector3) CR2WTypeManager.Create("Vector3", "ikEndPointOffset", cr2w, this);
				}
				return _ikEndPointOffset;
			}
			set
			{
				if (_ikEndPointOffset == value)
				{
					return;
				}
				_ikEndPointOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("ikEndRotationOffset")] 
		public Quaternion IkEndRotationOffset
		{
			get
			{
				if (_ikEndRotationOffset == null)
				{
					_ikEndRotationOffset = (Quaternion) CR2WTypeManager.Create("Quaternion", "ikEndRotationOffset", cr2w, this);
				}
				return _ikEndRotationOffset;
			}
			set
			{
				if (_ikEndRotationOffset == value)
				{
					return;
				}
				_ikEndRotationOffset = value;
				PropertySet(this);
			}
		}

		public animIKChainSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
