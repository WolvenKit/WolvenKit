using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class appearanceCensorshipEntry : CVariable
	{
		private CName _original;
		private CName _censored;
		private CUInt32 _censorFlags;

		[Ordinal(0)] 
		[RED("Original")] 
		public CName Original
		{
			get
			{
				if (_original == null)
				{
					_original = (CName) CR2WTypeManager.Create("CName", "Original", cr2w, this);
				}
				return _original;
			}
			set
			{
				if (_original == value)
				{
					return;
				}
				_original = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("Censored")] 
		public CName Censored
		{
			get
			{
				if (_censored == null)
				{
					_censored = (CName) CR2WTypeManager.Create("CName", "Censored", cr2w, this);
				}
				return _censored;
			}
			set
			{
				if (_censored == value)
				{
					return;
				}
				_censored = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("CensorFlags")] 
		public CUInt32 CensorFlags
		{
			get
			{
				if (_censorFlags == null)
				{
					_censorFlags = (CUInt32) CR2WTypeManager.Create("Uint32", "CensorFlags", cr2w, this);
				}
				return _censorFlags;
			}
			set
			{
				if (_censorFlags == value)
				{
					return;
				}
				_censorFlags = value;
				PropertySet(this);
			}
		}

		public appearanceCensorshipEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
