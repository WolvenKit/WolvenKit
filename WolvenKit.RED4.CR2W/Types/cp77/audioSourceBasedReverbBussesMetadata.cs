using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioSourceBasedReverbBussesMetadata : audioAudioMetadata
	{
		private CName _exterior;
		private CName _interiorLarge;
		private CName _interiorMedium;
		private CName _interiorSmall;

		[Ordinal(1)] 
		[RED("exterior")] 
		public CName Exterior
		{
			get
			{
				if (_exterior == null)
				{
					_exterior = (CName) CR2WTypeManager.Create("CName", "exterior", cr2w, this);
				}
				return _exterior;
			}
			set
			{
				if (_exterior == value)
				{
					return;
				}
				_exterior = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("interiorLarge")] 
		public CName InteriorLarge
		{
			get
			{
				if (_interiorLarge == null)
				{
					_interiorLarge = (CName) CR2WTypeManager.Create("CName", "interiorLarge", cr2w, this);
				}
				return _interiorLarge;
			}
			set
			{
				if (_interiorLarge == value)
				{
					return;
				}
				_interiorLarge = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("interiorMedium")] 
		public CName InteriorMedium
		{
			get
			{
				if (_interiorMedium == null)
				{
					_interiorMedium = (CName) CR2WTypeManager.Create("CName", "interiorMedium", cr2w, this);
				}
				return _interiorMedium;
			}
			set
			{
				if (_interiorMedium == value)
				{
					return;
				}
				_interiorMedium = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("interiorSmall")] 
		public CName InteriorSmall
		{
			get
			{
				if (_interiorSmall == null)
				{
					_interiorSmall = (CName) CR2WTypeManager.Create("CName", "interiorSmall", cr2w, this);
				}
				return _interiorSmall;
			}
			set
			{
				if (_interiorSmall == value)
				{
					return;
				}
				_interiorSmall = value;
				PropertySet(this);
			}
		}

		public audioSourceBasedReverbBussesMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
