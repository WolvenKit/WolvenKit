using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CHairProfile : CResource
	{
		private CUInt16 _sampleCount;
		private CArray<rendGradientEntry> _gradientEntriesID;
		private CArray<rendGradientEntry> _gradientEntriesRootToTip;

		[Ordinal(1)] 
		[RED("sampleCount")] 
		public CUInt16 SampleCount
		{
			get
			{
				if (_sampleCount == null)
				{
					_sampleCount = (CUInt16) CR2WTypeManager.Create("Uint16", "sampleCount", cr2w, this);
				}
				return _sampleCount;
			}
			set
			{
				if (_sampleCount == value)
				{
					return;
				}
				_sampleCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("gradientEntriesID")] 
		public CArray<rendGradientEntry> GradientEntriesID
		{
			get
			{
				if (_gradientEntriesID == null)
				{
					_gradientEntriesID = (CArray<rendGradientEntry>) CR2WTypeManager.Create("array:rendGradientEntry", "gradientEntriesID", cr2w, this);
				}
				return _gradientEntriesID;
			}
			set
			{
				if (_gradientEntriesID == value)
				{
					return;
				}
				_gradientEntriesID = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("gradientEntriesRootToTip")] 
		public CArray<rendGradientEntry> GradientEntriesRootToTip
		{
			get
			{
				if (_gradientEntriesRootToTip == null)
				{
					_gradientEntriesRootToTip = (CArray<rendGradientEntry>) CR2WTypeManager.Create("array:rendGradientEntry", "gradientEntriesRootToTip", cr2w, this);
				}
				return _gradientEntriesRootToTip;
			}
			set
			{
				if (_gradientEntriesRootToTip == value)
				{
					return;
				}
				_gradientEntriesRootToTip = value;
				PropertySet(this);
			}
		}

		public CHairProfile(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
