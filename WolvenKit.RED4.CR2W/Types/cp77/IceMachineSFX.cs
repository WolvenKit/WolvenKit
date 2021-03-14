using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IceMachineSFX : VendingMachineSFX
	{
		private CName _iceFalls;
		private CName _processing;

		[Ordinal(2)] 
		[RED("iceFalls")] 
		public CName IceFalls
		{
			get
			{
				if (_iceFalls == null)
				{
					_iceFalls = (CName) CR2WTypeManager.Create("CName", "iceFalls", cr2w, this);
				}
				return _iceFalls;
			}
			set
			{
				if (_iceFalls == value)
				{
					return;
				}
				_iceFalls = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("processing")] 
		public CName Processing
		{
			get
			{
				if (_processing == null)
				{
					_processing = (CName) CR2WTypeManager.Create("CName", "processing", cr2w, this);
				}
				return _processing;
			}
			set
			{
				if (_processing == value)
				{
					return;
				}
				_processing = value;
				PropertySet(this);
			}
		}

		public IceMachineSFX(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
