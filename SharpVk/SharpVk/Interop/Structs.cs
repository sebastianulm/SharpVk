﻿
using System;
using System.Runtime.InteropServices;

namespace SharpVk.Interop
{
	public struct Bool32
	{
		private uint value;

		public Bool32(bool value)
		{
			this.value = value ? 1u : 0;
		}

		public static implicit operator Bool32(bool value)
		{
			return new Bool32(value);
		}

		public static implicit operator bool(Bool32 value)
		{
			return value.value != 0;
		}
	}

	public struct DeviceSize
	{
		private ulong value;

		public static implicit operator DeviceSize(ulong iValue)
		{
			return new DeviceSize { value = iValue };
		}

		public static implicit operator ulong(DeviceSize size)
		{
			return size.value;
		}
	}

	public struct SampleMask
	{
		private uint value;

		public static implicit operator SampleMask(uint iValue)
		{
			return new SampleMask { value = iValue };
		}

		public static implicit operator uint(SampleMask size)
		{
			return size.value;
		}
	}

	public unsafe struct Offset2D
	{
		public static Offset2D* Create()
		{
			return (Offset2D*)HeapUtil.AllocateAndClear<Offset2D>();
		}

		public int X;

		public int Y;
	}

	public unsafe struct Offset3D
	{
		public static Offset3D* Create()
		{
			return (Offset3D*)HeapUtil.AllocateAndClear<Offset3D>();
		}

		public int X;

		public int Y;

		public int Z;
	}

	public unsafe struct Extent2D
	{
		public static Extent2D* Create()
		{
			return (Extent2D*)HeapUtil.AllocateAndClear<Extent2D>();
		}

		public uint Width;

		public uint Height;
	}

	public unsafe struct Extent3D
	{
		public static Extent3D* Create()
		{
			return (Extent3D*)HeapUtil.AllocateAndClear<Extent3D>();
		}

		public uint Width;

		public uint Height;

		public uint Depth;
	}

	public unsafe struct Viewport
	{
		public static Viewport* Create()
		{
			return (Viewport*)HeapUtil.AllocateAndClear<Viewport>();
		}

		public float X;

		public float Y;

		public float Width;

		public float Height;

		public float MinDepth;

		public float MaxDepth;
	}

	public unsafe struct Rect2D
	{
		public static Rect2D* Create()
		{
			return (Rect2D*)HeapUtil.AllocateAndClear<Rect2D>();
		}

		public Offset2D Offset;

		public Extent2D Extent;
	}

	public unsafe struct Rect3D
	{
		public static Rect3D* Create()
		{
			return (Rect3D*)HeapUtil.AllocateAndClear<Rect3D>();
		}

		public Offset3D Offset;

		public Extent3D Extent;
	}

	public unsafe struct ClearRect
	{
		public static ClearRect* Create()
		{
			return (ClearRect*)HeapUtil.AllocateAndClear<ClearRect>();
		}

		public Rect2D Rect;

		public uint BaseArrayLayer;

		public uint LayerCount;
	}

	public unsafe struct ComponentMapping
	{
		public static ComponentMapping* Create()
		{
			return (ComponentMapping*)HeapUtil.AllocateAndClear<ComponentMapping>();
		}

		public ComponentSwizzle R;

		public ComponentSwizzle G;

		public ComponentSwizzle B;

		public ComponentSwizzle A;
	}

	public unsafe struct PhysicalDeviceProperties
	{
		public static PhysicalDeviceProperties* Create()
		{
			return (PhysicalDeviceProperties*)HeapUtil.AllocateAndClear<PhysicalDeviceProperties>();
		}

		public uint ApiVersion;

		public uint DriverVersion;

		public uint VendorID;

		public uint DeviceID;

		public PhysicalDeviceType DeviceType;

		public char DeviceName;

		public byte PipelineCacheUUID;

		public PhysicalDeviceLimits Limits;

		public PhysicalDeviceSparseProperties SparseProperties;
	}

	public unsafe struct ExtensionProperties
	{
		public static ExtensionProperties* Create()
		{
			return (ExtensionProperties*)HeapUtil.AllocateAndClear<ExtensionProperties>();
		}

		public char ExtensionName;

		public uint SpecVersion;
	}

	public unsafe struct LayerProperties
	{
		public static LayerProperties* Create()
		{
			return (LayerProperties*)HeapUtil.AllocateAndClear<LayerProperties>();
		}

		public char LayerName;

		public uint SpecVersion;

		public uint ImplementationVersion;

		public char Description;
	}

	public unsafe struct ApplicationInfo
	{
		public static ApplicationInfo* Create()
		{
			return (ApplicationInfo*)HeapUtil.AllocateAndClear<ApplicationInfo>();
		}

		public StructureType SType;

		public void* Next;

		public char* ApplicationName;

		public uint ApplicationVersion;

		public char* EngineName;

		public uint EngineVersion;

		public uint ApiVersion;
	}

	public unsafe struct AllocationCallbacks
	{
		public static AllocationCallbacks* Create()
		{
			return (AllocationCallbacks*)HeapUtil.AllocateAndClear<AllocationCallbacks>();
		}

		public void* UserData;

		public IntPtr PfnAllocation;

		public IntPtr PfnReallocation;

		public IntPtr PfnFree;

		public IntPtr PfnInternalAllocation;

		public IntPtr PfnInternalFree;
	}

	public unsafe struct DeviceQueueCreateInfo
	{
		public static DeviceQueueCreateInfo* Create()
		{
			return (DeviceQueueCreateInfo*)HeapUtil.AllocateAndClear<DeviceQueueCreateInfo>();
		}

		public StructureType SType;

		public void* Next;

		public uint Flags;

		public uint QueueFamilyIndex;

		public uint QueueCount;

		public float* QueuePriorities;
	}

	public unsafe struct DeviceCreateInfo
	{
		public static DeviceCreateInfo* Create()
		{
			return (DeviceCreateInfo*)HeapUtil.AllocateAndClear<DeviceCreateInfo>();
		}

		public StructureType SType;

		public void* Next;

		public uint Flags;

		public uint QueueCreateInfoCount;

		public DeviceQueueCreateInfo* QueueCreateInfos;

		public uint EnabledLayerCount;

		public char** EnabledLayerNames;

		public uint EnabledExtensionCount;

		public char** EnabledExtensionNames;

		public PhysicalDeviceFeatures* EnabledFeatures;
	}

	public unsafe struct InstanceCreateInfo
	{
		public static InstanceCreateInfo* Create()
		{
			return (InstanceCreateInfo*)HeapUtil.AllocateAndClear<InstanceCreateInfo>();
		}

		public StructureType SType;

		public void* Next;

		public uint Flags;

		public ApplicationInfo* ApplicationInfo;

		public uint EnabledLayerCount;

		public char** EnabledLayerNames;

		public uint EnabledExtensionCount;

		public char** EnabledExtensionNames;
	}

	public unsafe struct QueueFamilyProperties
	{
		public static QueueFamilyProperties* Create()
		{
			return (QueueFamilyProperties*)HeapUtil.AllocateAndClear<QueueFamilyProperties>();
		}

		public uint QueueFlags;

		public uint QueueCount;

		public uint TimestampValidBits;

		public Extent3D MinImageTransferGranularity;
	}

	public unsafe struct PhysicalDeviceMemoryProperties
	{
		public static PhysicalDeviceMemoryProperties* Create()
		{
			return (PhysicalDeviceMemoryProperties*)HeapUtil.AllocateAndClear<PhysicalDeviceMemoryProperties>();
		}

		public uint MemoryTypeCount;

		public MemoryType MemoryTypes;

		public uint MemoryHeapCount;

		public MemoryHeap MemoryHeaps;
	}

	public unsafe struct MemoryAllocateInfo
	{
		public static MemoryAllocateInfo* Create()
		{
			return (MemoryAllocateInfo*)HeapUtil.AllocateAndClear<MemoryAllocateInfo>();
		}

		public StructureType SType;

		public void* Next;

		public DeviceSize AllocationSize;

		public uint MemoryTypeIndex;
	}

	public unsafe struct MemoryRequirements
	{
		public static MemoryRequirements* Create()
		{
			return (MemoryRequirements*)HeapUtil.AllocateAndClear<MemoryRequirements>();
		}

		public DeviceSize Size;

		public DeviceSize Alignment;

		public uint MemoryTypeBits;
	}

	public unsafe struct SparseImageFormatProperties
	{
		public static SparseImageFormatProperties* Create()
		{
			return (SparseImageFormatProperties*)HeapUtil.AllocateAndClear<SparseImageFormatProperties>();
		}

		public uint AspectMask;

		public Extent3D ImageGranularity;

		public uint Flags;
	}

	public unsafe struct SparseImageMemoryRequirements
	{
		public static SparseImageMemoryRequirements* Create()
		{
			return (SparseImageMemoryRequirements*)HeapUtil.AllocateAndClear<SparseImageMemoryRequirements>();
		}

		public SparseImageFormatProperties FormatProperties;

		public uint ImageMipTailFirstLod;

		public DeviceSize ImageMipTailSize;

		public DeviceSize ImageMipTailOffset;

		public DeviceSize ImageMipTailStride;
	}

	public unsafe struct MemoryType
	{
		public static MemoryType* Create()
		{
			return (MemoryType*)HeapUtil.AllocateAndClear<MemoryType>();
		}

		public uint PropertyFlags;

		public uint HeapIndex;
	}

	public unsafe struct MemoryHeap
	{
		public static MemoryHeap* Create()
		{
			return (MemoryHeap*)HeapUtil.AllocateAndClear<MemoryHeap>();
		}

		public DeviceSize Size;

		public uint Flags;
	}

	public unsafe struct MappedMemoryRange
	{
		public static MappedMemoryRange* Create()
		{
			return (MappedMemoryRange*)HeapUtil.AllocateAndClear<MappedMemoryRange>();
		}

		public StructureType SType;

		public void* Next;

		public DeviceMemory Memory;

		public DeviceSize Offset;

		public DeviceSize Size;
	}

	public unsafe struct FormatProperties
	{
		public static FormatProperties* Create()
		{
			return (FormatProperties*)HeapUtil.AllocateAndClear<FormatProperties>();
		}

		public uint LinearTilingFeatures;

		public uint OptimalTilingFeatures;

		public uint BufferFeatures;
	}

	public unsafe struct ImageFormatProperties
	{
		public static ImageFormatProperties* Create()
		{
			return (ImageFormatProperties*)HeapUtil.AllocateAndClear<ImageFormatProperties>();
		}

		public Extent3D MaxExtent;

		public uint MaxMipLevels;

		public uint MaxArrayLayers;

		public uint SampleCounts;

		public DeviceSize MaxResourceSize;
	}

	public unsafe struct DescriptorBufferInfo
	{
		public static DescriptorBufferInfo* Create()
		{
			return (DescriptorBufferInfo*)HeapUtil.AllocateAndClear<DescriptorBufferInfo>();
		}

		public Buffer Buffer;

		public DeviceSize Offset;

		public DeviceSize Range;
	}

	public unsafe struct DescriptorImageInfo
	{
		public static DescriptorImageInfo* Create()
		{
			return (DescriptorImageInfo*)HeapUtil.AllocateAndClear<DescriptorImageInfo>();
		}

		public Sampler Sampler;

		public ImageView ImageView;

		public ImageLayout ImageLayout;
	}

	public unsafe struct WriteDescriptorSet
	{
		public static WriteDescriptorSet* Create()
		{
			return (WriteDescriptorSet*)HeapUtil.AllocateAndClear<WriteDescriptorSet>();
		}

		public StructureType SType;

		public void* Next;

		public DescriptorSet DstSet;

		public uint DstBinding;

		public uint DstArrayElement;

		public uint DescriptorCount;

		public DescriptorType DescriptorType;

		public DescriptorImageInfo* ImageInfo;

		public DescriptorBufferInfo* BufferInfo;

		public BufferView* TexelBufferView;
	}

	public unsafe struct CopyDescriptorSet
	{
		public static CopyDescriptorSet* Create()
		{
			return (CopyDescriptorSet*)HeapUtil.AllocateAndClear<CopyDescriptorSet>();
		}

		public StructureType SType;

		public void* Next;

		public DescriptorSet SrcSet;

		public uint SrcBinding;

		public uint SrcArrayElement;

		public DescriptorSet DstSet;

		public uint DstBinding;

		public uint DstArrayElement;

		public uint DescriptorCount;
	}

	public unsafe struct BufferCreateInfo
	{
		public static BufferCreateInfo* Create()
		{
			return (BufferCreateInfo*)HeapUtil.AllocateAndClear<BufferCreateInfo>();
		}

		public StructureType SType;

		public void* Next;

		public uint Flags;

		public DeviceSize Size;

		public uint Usage;

		public SharingMode SharingMode;

		public uint QueueFamilyIndexCount;

		public uint* QueueFamilyIndices;
	}

	public unsafe struct BufferViewCreateInfo
	{
		public static BufferViewCreateInfo* Create()
		{
			return (BufferViewCreateInfo*)HeapUtil.AllocateAndClear<BufferViewCreateInfo>();
		}

		public StructureType SType;

		public void* Next;

		public uint Flags;

		public Buffer Buffer;

		public Format Format;

		public DeviceSize Offset;

		public DeviceSize Range;
	}

	public unsafe struct ImageSubresource
	{
		public static ImageSubresource* Create()
		{
			return (ImageSubresource*)HeapUtil.AllocateAndClear<ImageSubresource>();
		}

		public uint AspectMask;

		public uint MipLevel;

		public uint ArrayLayer;
	}

	public unsafe struct ImageSubresourceLayers
	{
		public static ImageSubresourceLayers* Create()
		{
			return (ImageSubresourceLayers*)HeapUtil.AllocateAndClear<ImageSubresourceLayers>();
		}

		public uint AspectMask;

		public uint MipLevel;

		public uint BaseArrayLayer;

		public uint LayerCount;
	}

	public unsafe struct ImageSubresourceRange
	{
		public static ImageSubresourceRange* Create()
		{
			return (ImageSubresourceRange*)HeapUtil.AllocateAndClear<ImageSubresourceRange>();
		}

		public uint AspectMask;

		public uint BaseMipLevel;

		public uint LevelCount;

		public uint BaseArrayLayer;

		public uint LayerCount;
	}

	public unsafe struct MemoryBarrier
	{
		public static MemoryBarrier* Create()
		{
			return (MemoryBarrier*)HeapUtil.AllocateAndClear<MemoryBarrier>();
		}

		public StructureType SType;

		public void* Next;

		public uint SrcAccessMask;

		public uint DstAccessMask;
	}

	public unsafe struct BufferMemoryBarrier
	{
		public static BufferMemoryBarrier* Create()
		{
			return (BufferMemoryBarrier*)HeapUtil.AllocateAndClear<BufferMemoryBarrier>();
		}

		public StructureType SType;

		public void* Next;

		public uint SrcAccessMask;

		public uint DstAccessMask;

		public uint SrcQueueFamilyIndex;

		public uint DstQueueFamilyIndex;

		public Buffer Buffer;

		public DeviceSize Offset;

		public DeviceSize Size;
	}

	public unsafe struct ImageMemoryBarrier
	{
		public static ImageMemoryBarrier* Create()
		{
			return (ImageMemoryBarrier*)HeapUtil.AllocateAndClear<ImageMemoryBarrier>();
		}

		public StructureType SType;

		public void* Next;

		public uint SrcAccessMask;

		public uint DstAccessMask;

		public ImageLayout OldLayout;

		public ImageLayout NewLayout;

		public uint SrcQueueFamilyIndex;

		public uint DstQueueFamilyIndex;

		public Image Image;

		public ImageSubresourceRange SubresourceRange;
	}

	public unsafe struct ImageCreateInfo
	{
		public static ImageCreateInfo* Create()
		{
			return (ImageCreateInfo*)HeapUtil.AllocateAndClear<ImageCreateInfo>();
		}

		public StructureType SType;

		public void* Next;

		public uint Flags;

		public ImageType ImageType;

		public Format Format;

		public Extent3D Extent;

		public uint MipLevels;

		public uint ArrayLayers;

		public SampleCountFlagBits Samples;

		public ImageTiling Tiling;

		public uint Usage;

		public SharingMode SharingMode;

		public uint QueueFamilyIndexCount;

		public uint* QueueFamilyIndices;

		public ImageLayout InitialLayout;
	}

	public unsafe struct SubresourceLayout
	{
		public static SubresourceLayout* Create()
		{
			return (SubresourceLayout*)HeapUtil.AllocateAndClear<SubresourceLayout>();
		}

		public DeviceSize Offset;

		public DeviceSize Size;

		public DeviceSize RowPitch;

		public DeviceSize ArrayPitch;

		public DeviceSize DepthPitch;
	}

	public unsafe struct ImageViewCreateInfo
	{
		public static ImageViewCreateInfo* Create()
		{
			return (ImageViewCreateInfo*)HeapUtil.AllocateAndClear<ImageViewCreateInfo>();
		}

		public StructureType SType;

		public void* Next;

		public uint Flags;

		public Image Image;

		public ImageViewType ViewType;

		public Format Format;

		public ComponentMapping Components;

		public ImageSubresourceRange SubresourceRange;
	}

	public unsafe struct BufferCopy
	{
		public static BufferCopy* Create()
		{
			return (BufferCopy*)HeapUtil.AllocateAndClear<BufferCopy>();
		}

		public DeviceSize SrcOffset;

		public DeviceSize DstOffset;

		public DeviceSize Size;
	}

	public unsafe struct SparseMemoryBind
	{
		public static SparseMemoryBind* Create()
		{
			return (SparseMemoryBind*)HeapUtil.AllocateAndClear<SparseMemoryBind>();
		}

		public DeviceSize ResourceOffset;

		public DeviceSize Size;

		public DeviceMemory Memory;

		public DeviceSize MemoryOffset;

		public uint Flags;
	}

	public unsafe struct SparseImageMemoryBind
	{
		public static SparseImageMemoryBind* Create()
		{
			return (SparseImageMemoryBind*)HeapUtil.AllocateAndClear<SparseImageMemoryBind>();
		}

		public ImageSubresource Subresource;

		public Offset3D Offset;

		public Extent3D Extent;

		public DeviceMemory Memory;

		public DeviceSize MemoryOffset;

		public uint Flags;
	}

	public unsafe struct SparseBufferMemoryBindInfo
	{
		public static SparseBufferMemoryBindInfo* Create()
		{
			return (SparseBufferMemoryBindInfo*)HeapUtil.AllocateAndClear<SparseBufferMemoryBindInfo>();
		}

		public Buffer Buffer;

		public uint BindCount;

		public SparseMemoryBind* Binds;
	}

	public unsafe struct SparseImageOpaqueMemoryBindInfo
	{
		public static SparseImageOpaqueMemoryBindInfo* Create()
		{
			return (SparseImageOpaqueMemoryBindInfo*)HeapUtil.AllocateAndClear<SparseImageOpaqueMemoryBindInfo>();
		}

		public Image Image;

		public uint BindCount;

		public SparseMemoryBind* Binds;
	}

	public unsafe struct SparseImageMemoryBindInfo
	{
		public static SparseImageMemoryBindInfo* Create()
		{
			return (SparseImageMemoryBindInfo*)HeapUtil.AllocateAndClear<SparseImageMemoryBindInfo>();
		}

		public Image Image;

		public uint BindCount;

		public SparseImageMemoryBind* Binds;
	}

	public unsafe struct BindSparseInfo
	{
		public static BindSparseInfo* Create()
		{
			return (BindSparseInfo*)HeapUtil.AllocateAndClear<BindSparseInfo>();
		}

		public StructureType SType;

		public void* Next;

		public uint WaitSemaphoreCount;

		public Semaphore* WaitSemaphores;

		public uint BufferBindCount;

		public SparseBufferMemoryBindInfo* BufferBinds;

		public uint ImageOpaqueBindCount;

		public SparseImageOpaqueMemoryBindInfo* ImageOpaqueBinds;

		public uint ImageBindCount;

		public SparseImageMemoryBindInfo* ImageBinds;

		public uint SignalSemaphoreCount;

		public Semaphore* SignalSemaphores;
	}

	public unsafe struct ImageCopy
	{
		public static ImageCopy* Create()
		{
			return (ImageCopy*)HeapUtil.AllocateAndClear<ImageCopy>();
		}

		public ImageSubresourceLayers SrcSubresource;

		public Offset3D SrcOffset;

		public ImageSubresourceLayers DstSubresource;

		public Offset3D DstOffset;

		public Extent3D Extent;
	}

	public unsafe struct ImageBlit
	{
		public static ImageBlit* Create()
		{
			return (ImageBlit*)HeapUtil.AllocateAndClear<ImageBlit>();
		}

		public ImageSubresourceLayers SrcSubresource;

		public Offset3D SrcOffsets0;

		public Offset3D SrcOffsets1;

		public ImageSubresourceLayers DstSubresource;

		public Offset3D DstOffsets0;

		public Offset3D DstOffsets1;
	}

	public unsafe struct BufferImageCopy
	{
		public static BufferImageCopy* Create()
		{
			return (BufferImageCopy*)HeapUtil.AllocateAndClear<BufferImageCopy>();
		}

		public DeviceSize BufferOffset;

		public uint BufferRowLength;

		public uint BufferImageHeight;

		public ImageSubresourceLayers ImageSubresource;

		public Offset3D ImageOffset;

		public Extent3D ImageExtent;
	}

	public unsafe struct ImageResolve
	{
		public static ImageResolve* Create()
		{
			return (ImageResolve*)HeapUtil.AllocateAndClear<ImageResolve>();
		}

		public ImageSubresourceLayers SrcSubresource;

		public Offset3D SrcOffset;

		public ImageSubresourceLayers DstSubresource;

		public Offset3D DstOffset;

		public Extent3D Extent;
	}

	public unsafe struct ShaderModuleCreateInfo
	{
		public static ShaderModuleCreateInfo* Create()
		{
			return (ShaderModuleCreateInfo*)HeapUtil.AllocateAndClear<ShaderModuleCreateInfo>();
		}

		public StructureType SType;

		public void* Next;

		public uint Flags;

		public UIntPtr CodeSize;

		public uint* Code;
	}

	public unsafe struct DescriptorSetLayoutBinding
	{
		public static DescriptorSetLayoutBinding* Create()
		{
			return (DescriptorSetLayoutBinding*)HeapUtil.AllocateAndClear<DescriptorSetLayoutBinding>();
		}

		public uint Binding;

		public DescriptorType DescriptorType;

		public uint DescriptorCount;

		public uint StageFlags;

		public Sampler* ImmutableSamplers;
	}

	public unsafe struct DescriptorSetLayoutCreateInfo
	{
		public static DescriptorSetLayoutCreateInfo* Create()
		{
			return (DescriptorSetLayoutCreateInfo*)HeapUtil.AllocateAndClear<DescriptorSetLayoutCreateInfo>();
		}

		public StructureType SType;

		public void* Next;

		public uint Flags;

		public uint BindingCount;

		public DescriptorSetLayoutBinding* Bindings;
	}

	public unsafe struct DescriptorPoolSize
	{
		public static DescriptorPoolSize* Create()
		{
			return (DescriptorPoolSize*)HeapUtil.AllocateAndClear<DescriptorPoolSize>();
		}

		public DescriptorType Type;

		public uint DescriptorCount;
	}

	public unsafe struct DescriptorPoolCreateInfo
	{
		public static DescriptorPoolCreateInfo* Create()
		{
			return (DescriptorPoolCreateInfo*)HeapUtil.AllocateAndClear<DescriptorPoolCreateInfo>();
		}

		public StructureType SType;

		public void* Next;

		public uint Flags;

		public uint MaxSets;

		public uint PoolSizeCount;

		public DescriptorPoolSize* PoolSizes;
	}

	public unsafe struct DescriptorSetAllocateInfo
	{
		public static DescriptorSetAllocateInfo* Create()
		{
			return (DescriptorSetAllocateInfo*)HeapUtil.AllocateAndClear<DescriptorSetAllocateInfo>();
		}

		public StructureType SType;

		public void* Next;

		public DescriptorPool DescriptorPool;

		public uint DescriptorSetCount;

		public DescriptorSetLayout* SetLayouts;
	}

	public unsafe struct SpecializationMapEntry
	{
		public static SpecializationMapEntry* Create()
		{
			return (SpecializationMapEntry*)HeapUtil.AllocateAndClear<SpecializationMapEntry>();
		}

		public uint ConstantID;

		public uint Offset;

		public UIntPtr Size;
	}

	public unsafe struct SpecializationInfo
	{
		public static SpecializationInfo* Create()
		{
			return (SpecializationInfo*)HeapUtil.AllocateAndClear<SpecializationInfo>();
		}

		public uint MapEntryCount;

		public SpecializationMapEntry* MapEntries;

		public UIntPtr DataSize;

		public void* Data;
	}

	public unsafe struct PipelineShaderStageCreateInfo
	{
		public static PipelineShaderStageCreateInfo* Create()
		{
			return (PipelineShaderStageCreateInfo*)HeapUtil.AllocateAndClear<PipelineShaderStageCreateInfo>();
		}

		public StructureType SType;

		public void* Next;

		public uint Flags;

		public ShaderStageFlagBits Stage;

		public ShaderModule Module;

		public char* Name;

		public SpecializationInfo* SpecializationInfo;
	}

	public unsafe struct ComputePipelineCreateInfo
	{
		public static ComputePipelineCreateInfo* Create()
		{
			return (ComputePipelineCreateInfo*)HeapUtil.AllocateAndClear<ComputePipelineCreateInfo>();
		}

		public StructureType SType;

		public void* Next;

		public uint Flags;

		public PipelineShaderStageCreateInfo Stage;

		public PipelineLayout Layout;

		public Pipeline BasePipelineHandle;

		public int BasePipelineIndex;
	}

	public unsafe struct VertexInputBindingDescription
	{
		public static VertexInputBindingDescription* Create()
		{
			return (VertexInputBindingDescription*)HeapUtil.AllocateAndClear<VertexInputBindingDescription>();
		}

		public uint Binding;

		public uint Stride;

		public VertexInputRate InputRate;
	}

	public unsafe struct VertexInputAttributeDescription
	{
		public static VertexInputAttributeDescription* Create()
		{
			return (VertexInputAttributeDescription*)HeapUtil.AllocateAndClear<VertexInputAttributeDescription>();
		}

		public uint Location;

		public uint Binding;

		public Format Format;

		public uint Offset;
	}

	public unsafe struct PipelineVertexInputStateCreateInfo
	{
		public static PipelineVertexInputStateCreateInfo* Create()
		{
			return (PipelineVertexInputStateCreateInfo*)HeapUtil.AllocateAndClear<PipelineVertexInputStateCreateInfo>();
		}

		public StructureType SType;

		public void* Next;

		public uint Flags;

		public uint VertexBindingDescriptionCount;

		public VertexInputBindingDescription* VertexBindingDescriptions;

		public uint VertexAttributeDescriptionCount;

		public VertexInputAttributeDescription* VertexAttributeDescriptions;
	}

	public unsafe struct PipelineInputAssemblyStateCreateInfo
	{
		public static PipelineInputAssemblyStateCreateInfo* Create()
		{
			return (PipelineInputAssemblyStateCreateInfo*)HeapUtil.AllocateAndClear<PipelineInputAssemblyStateCreateInfo>();
		}

		public StructureType SType;

		public void* Next;

		public uint Flags;

		public PrimitiveTopology Topology;

		public Bool32 PrimitiveRestartEnable;
	}

	public unsafe struct PipelineTessellationStateCreateInfo
	{
		public static PipelineTessellationStateCreateInfo* Create()
		{
			return (PipelineTessellationStateCreateInfo*)HeapUtil.AllocateAndClear<PipelineTessellationStateCreateInfo>();
		}

		public StructureType SType;

		public void* Next;

		public uint Flags;

		public uint PatchControlPoints;
	}

	public unsafe struct PipelineViewportStateCreateInfo
	{
		public static PipelineViewportStateCreateInfo* Create()
		{
			return (PipelineViewportStateCreateInfo*)HeapUtil.AllocateAndClear<PipelineViewportStateCreateInfo>();
		}

		public StructureType SType;

		public void* Next;

		public uint Flags;

		public uint ViewportCount;

		public Viewport* Viewports;

		public uint ScissorCount;

		public Rect2D* Scissors;
	}

	public unsafe struct PipelineRasterizationStateCreateInfo
	{
		public static PipelineRasterizationStateCreateInfo* Create()
		{
			return (PipelineRasterizationStateCreateInfo*)HeapUtil.AllocateAndClear<PipelineRasterizationStateCreateInfo>();
		}

		public StructureType SType;

		public void* Next;

		public uint Flags;

		public Bool32 DepthClampEnable;

		public Bool32 RasterizerDiscardEnable;

		public PolygonMode PolygonMode;

		public uint CullMode;

		public FrontFace FrontFace;

		public Bool32 DepthBiasEnable;

		public float DepthBiasConstantFactor;

		public float DepthBiasClamp;

		public float DepthBiasSlopeFactor;

		public float LineWidth;
	}

	public unsafe struct PipelineMultisampleStateCreateInfo
	{
		public static PipelineMultisampleStateCreateInfo* Create()
		{
			return (PipelineMultisampleStateCreateInfo*)HeapUtil.AllocateAndClear<PipelineMultisampleStateCreateInfo>();
		}

		public StructureType SType;

		public void* Next;

		public uint Flags;

		public SampleCountFlagBits RasterizationSamples;

		public Bool32 SampleShadingEnable;

		public float MinSampleShading;

		public SampleMask* SampleMask;

		public Bool32 AlphaToCoverageEnable;

		public Bool32 AlphaToOneEnable;
	}

	public unsafe struct PipelineColorBlendAttachmentState
	{
		public static PipelineColorBlendAttachmentState* Create()
		{
			return (PipelineColorBlendAttachmentState*)HeapUtil.AllocateAndClear<PipelineColorBlendAttachmentState>();
		}

		public Bool32 BlendEnable;

		public BlendFactor SrcColorBlendFactor;

		public BlendFactor DstColorBlendFactor;

		public BlendOp ColorBlendOp;

		public BlendFactor SrcAlphaBlendFactor;

		public BlendFactor DstAlphaBlendFactor;

		public BlendOp AlphaBlendOp;

		public uint ColorWriteMask;
	}

	public unsafe struct PipelineColorBlendStateCreateInfo
	{
		public static PipelineColorBlendStateCreateInfo* Create()
		{
			return (PipelineColorBlendStateCreateInfo*)HeapUtil.AllocateAndClear<PipelineColorBlendStateCreateInfo>();
		}

		public StructureType SType;

		public void* Next;

		public uint Flags;

		public Bool32 LogicOpEnable;

		public LogicOp LogicOp;

		public uint AttachmentCount;

		public PipelineColorBlendAttachmentState* Attachments;

		public float BlendConstants;
	}

	public unsafe struct PipelineDynamicStateCreateInfo
	{
		public static PipelineDynamicStateCreateInfo* Create()
		{
			return (PipelineDynamicStateCreateInfo*)HeapUtil.AllocateAndClear<PipelineDynamicStateCreateInfo>();
		}

		public StructureType SType;

		public void* Next;

		public uint Flags;

		public uint DynamicStateCount;

		public DynamicState* DynamicStates;
	}

	public unsafe struct StencilOpState
	{
		public static StencilOpState* Create()
		{
			return (StencilOpState*)HeapUtil.AllocateAndClear<StencilOpState>();
		}

		public StencilOp FailOp;

		public StencilOp PassOp;

		public StencilOp DepthFailOp;

		public CompareOp CompareOp;

		public uint CompareMask;

		public uint WriteMask;

		public uint Reference;
	}

	public unsafe struct PipelineDepthStencilStateCreateInfo
	{
		public static PipelineDepthStencilStateCreateInfo* Create()
		{
			return (PipelineDepthStencilStateCreateInfo*)HeapUtil.AllocateAndClear<PipelineDepthStencilStateCreateInfo>();
		}

		public StructureType SType;

		public void* Next;

		public uint Flags;

		public Bool32 DepthTestEnable;

		public Bool32 DepthWriteEnable;

		public CompareOp DepthCompareOp;

		public Bool32 DepthBoundsTestEnable;

		public Bool32 StencilTestEnable;

		public StencilOpState Front;

		public StencilOpState Back;

		public float MinDepthBounds;

		public float MaxDepthBounds;
	}

	public unsafe struct GraphicsPipelineCreateInfo
	{
		public static GraphicsPipelineCreateInfo* Create()
		{
			return (GraphicsPipelineCreateInfo*)HeapUtil.AllocateAndClear<GraphicsPipelineCreateInfo>();
		}

		public StructureType SType;

		public void* Next;

		public uint Flags;

		public uint StageCount;

		public PipelineShaderStageCreateInfo* Stages;

		public PipelineVertexInputStateCreateInfo* VertexInputState;

		public PipelineInputAssemblyStateCreateInfo* InputAssemblyState;

		public PipelineTessellationStateCreateInfo* TessellationState;

		public PipelineViewportStateCreateInfo* ViewportState;

		public PipelineRasterizationStateCreateInfo* RasterizationState;

		public PipelineMultisampleStateCreateInfo* MultisampleState;

		public PipelineDepthStencilStateCreateInfo* DepthStencilState;

		public PipelineColorBlendStateCreateInfo* ColorBlendState;

		public PipelineDynamicStateCreateInfo* DynamicState;

		public PipelineLayout Layout;

		public RenderPass RenderPass;

		public uint Subpass;

		public Pipeline BasePipelineHandle;

		public int BasePipelineIndex;
	}

	public unsafe struct PipelineCacheCreateInfo
	{
		public static PipelineCacheCreateInfo* Create()
		{
			return (PipelineCacheCreateInfo*)HeapUtil.AllocateAndClear<PipelineCacheCreateInfo>();
		}

		public StructureType SType;

		public void* Next;

		public uint Flags;

		public UIntPtr InitialDataSize;

		public void* InitialData;
	}

	public unsafe struct PushConstantRange
	{
		public static PushConstantRange* Create()
		{
			return (PushConstantRange*)HeapUtil.AllocateAndClear<PushConstantRange>();
		}

		public uint StageFlags;

		public uint Offset;

		public uint Size;
	}

	public unsafe struct PipelineLayoutCreateInfo
	{
		public static PipelineLayoutCreateInfo* Create()
		{
			return (PipelineLayoutCreateInfo*)HeapUtil.AllocateAndClear<PipelineLayoutCreateInfo>();
		}

		public StructureType SType;

		public void* Next;

		public uint Flags;

		public uint SetLayoutCount;

		public DescriptorSetLayout* SetLayouts;

		public uint PushConstantRangeCount;

		public PushConstantRange* PushConstantRanges;
	}

	public unsafe struct SamplerCreateInfo
	{
		public static SamplerCreateInfo* Create()
		{
			return (SamplerCreateInfo*)HeapUtil.AllocateAndClear<SamplerCreateInfo>();
		}

		public StructureType SType;

		public void* Next;

		public uint Flags;

		public Filter MagFilter;

		public Filter MinFilter;

		public SamplerMipmapMode MipmapMode;

		public SamplerAddressMode AddressModeU;

		public SamplerAddressMode AddressModeV;

		public SamplerAddressMode AddressModeW;

		public float MipLodBias;

		public Bool32 AnisotropyEnable;

		public float MaxAnisotropy;

		public Bool32 CompareEnable;

		public CompareOp CompareOp;

		public float MinLod;

		public float MaxLod;

		public BorderColor BorderColor;

		public Bool32 UnnormalizedCoordinates;
	}

	public unsafe struct CommandPoolCreateInfo
	{
		public static CommandPoolCreateInfo* Create()
		{
			return (CommandPoolCreateInfo*)HeapUtil.AllocateAndClear<CommandPoolCreateInfo>();
		}

		public StructureType SType;

		public void* Next;

		public uint Flags;

		public uint QueueFamilyIndex;
	}

	public unsafe struct CommandBufferAllocateInfo
	{
		public static CommandBufferAllocateInfo* Create()
		{
			return (CommandBufferAllocateInfo*)HeapUtil.AllocateAndClear<CommandBufferAllocateInfo>();
		}

		public StructureType SType;

		public void* Next;

		public CommandPool CommandPool;

		public CommandBufferLevel Level;

		public uint CommandBufferCount;
	}

	public unsafe struct CommandBufferInheritanceInfo
	{
		public static CommandBufferInheritanceInfo* Create()
		{
			return (CommandBufferInheritanceInfo*)HeapUtil.AllocateAndClear<CommandBufferInheritanceInfo>();
		}

		public StructureType SType;

		public void* Next;

		public RenderPass RenderPass;

		public uint Subpass;

		public Framebuffer Framebuffer;

		public Bool32 OcclusionQueryEnable;

		public uint QueryFlags;

		public uint PipelineStatistics;
	}

	public unsafe struct CommandBufferBeginInfo
	{
		public static CommandBufferBeginInfo* Create()
		{
			return (CommandBufferBeginInfo*)HeapUtil.AllocateAndClear<CommandBufferBeginInfo>();
		}

		public StructureType SType;

		public void* Next;

		public uint Flags;

		public CommandBufferInheritanceInfo* InheritanceInfo;
	}

	public unsafe struct RenderPassBeginInfo
	{
		public static RenderPassBeginInfo* Create()
		{
			return (RenderPassBeginInfo*)HeapUtil.AllocateAndClear<RenderPassBeginInfo>();
		}

		public StructureType SType;

		public void* Next;

		public RenderPass RenderPass;

		public Framebuffer Framebuffer;

		public Rect2D RenderArea;

		public uint ClearValueCount;

		public ClearValue* ClearValues;
	}

	public unsafe struct ClearDepthStencilValue
	{
		public static ClearDepthStencilValue* Create()
		{
			return (ClearDepthStencilValue*)HeapUtil.AllocateAndClear<ClearDepthStencilValue>();
		}

		public float Depth;

		public uint Stencil;
	}

	public unsafe struct ClearAttachment
	{
		public static ClearAttachment* Create()
		{
			return (ClearAttachment*)HeapUtil.AllocateAndClear<ClearAttachment>();
		}

		public uint AspectMask;

		public uint ColorAttachment;

		public ClearValue ClearValue;
	}

	public unsafe struct AttachmentDescription
	{
		public static AttachmentDescription* Create()
		{
			return (AttachmentDescription*)HeapUtil.AllocateAndClear<AttachmentDescription>();
		}

		public uint Flags;

		public Format Format;

		public SampleCountFlagBits Samples;

		public AttachmentLoadOp LoadOp;

		public AttachmentStoreOp StoreOp;

		public AttachmentLoadOp StencilLoadOp;

		public AttachmentStoreOp StencilStoreOp;

		public ImageLayout InitialLayout;

		public ImageLayout FinalLayout;
	}

	public unsafe struct AttachmentReference
	{
		public static AttachmentReference* Create()
		{
			return (AttachmentReference*)HeapUtil.AllocateAndClear<AttachmentReference>();
		}

		public uint Attachment;

		public ImageLayout Layout;
	}

	public unsafe struct SubpassDescription
	{
		public static SubpassDescription* Create()
		{
			return (SubpassDescription*)HeapUtil.AllocateAndClear<SubpassDescription>();
		}

		public uint Flags;

		public PipelineBindPoint PipelineBindPoint;

		public uint InputAttachmentCount;

		public AttachmentReference* InputAttachments;

		public uint ColorAttachmentCount;

		public AttachmentReference* ColorAttachments;

		public AttachmentReference* ResolveAttachments;

		public AttachmentReference* DepthStencilAttachment;

		public uint PreserveAttachmentCount;

		public uint* PreserveAttachments;
	}

	public unsafe struct SubpassDependency
	{
		public static SubpassDependency* Create()
		{
			return (SubpassDependency*)HeapUtil.AllocateAndClear<SubpassDependency>();
		}

		public uint SrcSubpass;

		public uint DstSubpass;

		public uint SrcStageMask;

		public uint DstStageMask;

		public uint SrcAccessMask;

		public uint DstAccessMask;

		public uint DependencyFlags;
	}

	public unsafe struct RenderPassCreateInfo
	{
		public static RenderPassCreateInfo* Create()
		{
			return (RenderPassCreateInfo*)HeapUtil.AllocateAndClear<RenderPassCreateInfo>();
		}

		public StructureType SType;

		public void* Next;

		public uint Flags;

		public uint AttachmentCount;

		public AttachmentDescription* Attachments;

		public uint SubpassCount;

		public SubpassDescription* Subpasses;

		public uint DependencyCount;

		public SubpassDependency* Dependencies;
	}

	public unsafe struct EventCreateInfo
	{
		public static EventCreateInfo* Create()
		{
			return (EventCreateInfo*)HeapUtil.AllocateAndClear<EventCreateInfo>();
		}

		public StructureType SType;

		public void* Next;

		public uint Flags;
	}

	public unsafe struct FenceCreateInfo
	{
		public static FenceCreateInfo* Create()
		{
			return (FenceCreateInfo*)HeapUtil.AllocateAndClear<FenceCreateInfo>();
		}

		public StructureType SType;

		public void* Next;

		public uint Flags;
	}

	public unsafe struct PhysicalDeviceFeatures
	{
		public static PhysicalDeviceFeatures* Create()
		{
			return (PhysicalDeviceFeatures*)HeapUtil.AllocateAndClear<PhysicalDeviceFeatures>();
		}

		public Bool32 RobustBufferAccess;

		public Bool32 FullDrawIndexUint32;

		public Bool32 ImageCubeArray;

		public Bool32 IndependentBlend;

		public Bool32 GeometryShader;

		public Bool32 TessellationShader;

		public Bool32 SampleRateShading;

		public Bool32 DualSrcBlend;

		public Bool32 LogicOp;

		public Bool32 MultiDrawIndirect;

		public Bool32 DrawIndirectFirstInstance;

		public Bool32 DepthClamp;

		public Bool32 DepthBiasClamp;

		public Bool32 FillModeNonSolid;

		public Bool32 DepthBounds;

		public Bool32 WideLines;

		public Bool32 LargePoints;

		public Bool32 AlphaToOne;

		public Bool32 MultiViewport;

		public Bool32 SamplerAnisotropy;

		public Bool32 TextureCompressionETC2;

		public Bool32 TextureCompressionASTC_LDR;

		public Bool32 TextureCompressionBC;

		public Bool32 OcclusionQueryPrecise;

		public Bool32 PipelineStatisticsQuery;

		public Bool32 VertexPipelineStoresAndAtomics;

		public Bool32 FragmentStoresAndAtomics;

		public Bool32 ShaderTessellationAndGeometryPointSize;

		public Bool32 ShaderImageGatherExtended;

		public Bool32 ShaderStorageImageExtendedFormats;

		public Bool32 ShaderStorageImageMultisample;

		public Bool32 ShaderStorageImageReadWithoutFormat;

		public Bool32 ShaderStorageImageWriteWithoutFormat;

		public Bool32 ShaderUniformBufferArrayDynamicIndexing;

		public Bool32 ShaderSampledImageArrayDynamicIndexing;

		public Bool32 ShaderStorageBufferArrayDynamicIndexing;

		public Bool32 ShaderStorageImageArrayDynamicIndexing;

		public Bool32 ShaderClipDistance;

		public Bool32 ShaderCullDistance;

		public Bool32 ShaderFloat64;

		public Bool32 ShaderInt64;

		public Bool32 ShaderInt16;

		public Bool32 ShaderResourceResidency;

		public Bool32 ShaderResourceMinLod;

		public Bool32 SparseBinding;

		public Bool32 SparseResidencyBuffer;

		public Bool32 SparseResidencyImage2D;

		public Bool32 SparseResidencyImage3D;

		public Bool32 SparseResidency2Samples;

		public Bool32 SparseResidency4Samples;

		public Bool32 SparseResidency8Samples;

		public Bool32 SparseResidency16Samples;

		public Bool32 SparseResidencyAliased;

		public Bool32 VariableMultisampleRate;

		public Bool32 InheritedQueries;
	}

	public unsafe struct PhysicalDeviceSparseProperties
	{
		public static PhysicalDeviceSparseProperties* Create()
		{
			return (PhysicalDeviceSparseProperties*)HeapUtil.AllocateAndClear<PhysicalDeviceSparseProperties>();
		}

		public Bool32 ResidencyStandard2DBlockShape;

		public Bool32 ResidencyStandard2DMultisampleBlockShape;

		public Bool32 ResidencyStandard3DBlockShape;

		public Bool32 ResidencyAlignedMipSize;

		public Bool32 ResidencyNonResidentStrict;
	}

	public unsafe struct PhysicalDeviceLimits
	{
		public static PhysicalDeviceLimits* Create()
		{
			return (PhysicalDeviceLimits*)HeapUtil.AllocateAndClear<PhysicalDeviceLimits>();
		}

		public uint MaxImageDimension1D;

		public uint MaxImageDimension2D;

		public uint MaxImageDimension3D;

		public uint MaxImageDimensionCube;

		public uint MaxImageArrayLayers;

		public uint MaxTexelBufferElements;

		public uint MaxUniformBufferRange;

		public uint MaxStorageBufferRange;

		public uint MaxPushConstantsSize;

		public uint MaxMemoryAllocationCount;

		public uint MaxSamplerAllocationCount;

		public DeviceSize BufferImageGranularity;

		public DeviceSize SparseAddressSpaceSize;

		public uint MaxBoundDescriptorSets;

		public uint MaxPerStageDescriptorSamplers;

		public uint MaxPerStageDescriptorUniformBuffers;

		public uint MaxPerStageDescriptorStorageBuffers;

		public uint MaxPerStageDescriptorSampledImages;

		public uint MaxPerStageDescriptorStorageImages;

		public uint MaxPerStageDescriptorInputAttachments;

		public uint MaxPerStageResources;

		public uint MaxDescriptorSetSamplers;

		public uint MaxDescriptorSetUniformBuffers;

		public uint MaxDescriptorSetUniformBuffersDynamic;

		public uint MaxDescriptorSetStorageBuffers;

		public uint MaxDescriptorSetStorageBuffersDynamic;

		public uint MaxDescriptorSetSampledImages;

		public uint MaxDescriptorSetStorageImages;

		public uint MaxDescriptorSetInputAttachments;

		public uint MaxVertexInputAttributes;

		public uint MaxVertexInputBindings;

		public uint MaxVertexInputAttributeOffset;

		public uint MaxVertexInputBindingStride;

		public uint MaxVertexOutputComponents;

		public uint MaxTessellationGenerationLevel;

		public uint MaxTessellationPatchSize;

		public uint MaxTessellationControlPerVertexInputComponents;

		public uint MaxTessellationControlPerVertexOutputComponents;

		public uint MaxTessellationControlPerPatchOutputComponents;

		public uint MaxTessellationControlTotalOutputComponents;

		public uint MaxTessellationEvaluationInputComponents;

		public uint MaxTessellationEvaluationOutputComponents;

		public uint MaxGeometryShaderInvocations;

		public uint MaxGeometryInputComponents;

		public uint MaxGeometryOutputComponents;

		public uint MaxGeometryOutputVertices;

		public uint MaxGeometryTotalOutputComponents;

		public uint MaxFragmentInputComponents;

		public uint MaxFragmentOutputAttachments;

		public uint MaxFragmentDualSrcAttachments;

		public uint MaxFragmentCombinedOutputResources;

		public uint MaxComputeSharedMemorySize;

		public uint MaxComputeWorkGroupCount;

		public uint MaxComputeWorkGroupInvocations;

		public uint MaxComputeWorkGroupSize;

		public uint SubPixelPrecisionBits;

		public uint SubTexelPrecisionBits;

		public uint MipmapPrecisionBits;

		public uint MaxDrawIndexedIndexValue;

		public uint MaxDrawIndirectCount;

		public float MaxSamplerLodBias;

		public float MaxSamplerAnisotropy;

		public uint MaxViewports;

		public uint MaxViewportDimensions;

		public float ViewportBoundsRange;

		public uint ViewportSubPixelBits;

		public UIntPtr MinMemoryMapAlignment;

		public DeviceSize MinTexelBufferOffsetAlignment;

		public DeviceSize MinUniformBufferOffsetAlignment;

		public DeviceSize MinStorageBufferOffsetAlignment;

		public int MinTexelOffset;

		public uint MaxTexelOffset;

		public int MinTexelGatherOffset;

		public uint MaxTexelGatherOffset;

		public float MinInterpolationOffset;

		public float MaxInterpolationOffset;

		public uint SubPixelInterpolationOffsetBits;

		public uint MaxFramebufferWidth;

		public uint MaxFramebufferHeight;

		public uint MaxFramebufferLayers;

		public uint FramebufferColorSampleCounts;

		public uint FramebufferDepthSampleCounts;

		public uint FramebufferStencilSampleCounts;

		public uint FramebufferNoAttachmentsSampleCounts;

		public uint MaxColorAttachments;

		public uint SampledImageColorSampleCounts;

		public uint SampledImageIntegerSampleCounts;

		public uint SampledImageDepthSampleCounts;

		public uint SampledImageStencilSampleCounts;

		public uint StorageImageSampleCounts;

		public uint MaxSampleMaskWords;

		public Bool32 TimestampComputeAndGraphics;

		public float TimestampPeriod;

		public uint MaxClipDistances;

		public uint MaxCullDistances;

		public uint MaxCombinedClipAndCullDistances;

		public uint DiscreteQueuePriorities;

		public float PointSizeRange;

		public float LineWidthRange;

		public float PointSizeGranularity;

		public float LineWidthGranularity;

		public Bool32 StrictLines;

		public Bool32 StandardSampleLocations;

		public DeviceSize OptimalBufferCopyOffsetAlignment;

		public DeviceSize OptimalBufferCopyRowPitchAlignment;

		public DeviceSize NonCoherentAtomSize;
	}

	public unsafe struct SemaphoreCreateInfo
	{
		public static SemaphoreCreateInfo* Create()
		{
			return (SemaphoreCreateInfo*)HeapUtil.AllocateAndClear<SemaphoreCreateInfo>();
		}

		public StructureType SType;

		public void* Next;

		public uint Flags;
	}

	public unsafe struct QueryPoolCreateInfo
	{
		public static QueryPoolCreateInfo* Create()
		{
			return (QueryPoolCreateInfo*)HeapUtil.AllocateAndClear<QueryPoolCreateInfo>();
		}

		public StructureType SType;

		public void* Next;

		public uint Flags;

		public QueryType QueryType;

		public uint QueryCount;

		public uint PipelineStatistics;
	}

	public unsafe struct FramebufferCreateInfo
	{
		public static FramebufferCreateInfo* Create()
		{
			return (FramebufferCreateInfo*)HeapUtil.AllocateAndClear<FramebufferCreateInfo>();
		}

		public StructureType SType;

		public void* Next;

		public uint Flags;

		public RenderPass RenderPass;

		public uint AttachmentCount;

		public ImageView* Attachments;

		public uint Width;

		public uint Height;

		public uint Layers;
	}

	public unsafe struct DrawIndirectCommand
	{
		public static DrawIndirectCommand* Create()
		{
			return (DrawIndirectCommand*)HeapUtil.AllocateAndClear<DrawIndirectCommand>();
		}

		public uint VertexCount;

		public uint InstanceCount;

		public uint FirstVertex;

		public uint FirstInstance;
	}

	public unsafe struct DrawIndexedIndirectCommand
	{
		public static DrawIndexedIndirectCommand* Create()
		{
			return (DrawIndexedIndirectCommand*)HeapUtil.AllocateAndClear<DrawIndexedIndirectCommand>();
		}

		public uint IndexCount;

		public uint InstanceCount;

		public uint FirstIndex;

		public int VertexOffset;

		public uint FirstInstance;
	}

	public unsafe struct DispatchIndirectCommand
	{
		public static DispatchIndirectCommand* Create()
		{
			return (DispatchIndirectCommand*)HeapUtil.AllocateAndClear<DispatchIndirectCommand>();
		}

		public uint X;

		public uint Y;

		public uint Z;
	}

	public unsafe struct SubmitInfo
	{
		public static SubmitInfo* Create()
		{
			return (SubmitInfo*)HeapUtil.AllocateAndClear<SubmitInfo>();
		}

		public StructureType SType;

		public void* Next;

		public uint WaitSemaphoreCount;

		public Semaphore* WaitSemaphores;

		public uint* WaitDstStageMask;

		public uint CommandBufferCount;

		public CommandBuffer* CommandBuffers;

		public uint SignalSemaphoreCount;

		public Semaphore* SignalSemaphores;
	}

	public unsafe struct DisplayPropertiesKHR
	{
		public static DisplayPropertiesKHR* Create()
		{
			return (DisplayPropertiesKHR*)HeapUtil.AllocateAndClear<DisplayPropertiesKHR>();
		}

		public DisplayKHR Display;

		public char DisplayName;

		public Extent2D PhysicalDimensions;

		public Extent2D PhysicalResolution;

		public uint SupportedTransforms;

		public Bool32 PlaneReorderPossible;

		public Bool32 PersistentContent;
	}

	public unsafe struct DisplayPlanePropertiesKHR
	{
		public static DisplayPlanePropertiesKHR* Create()
		{
			return (DisplayPlanePropertiesKHR*)HeapUtil.AllocateAndClear<DisplayPlanePropertiesKHR>();
		}

		public DisplayKHR CurrentDisplay;

		public uint CurrentStackIndex;
	}

	public unsafe struct DisplayModeParametersKHR
	{
		public static DisplayModeParametersKHR* Create()
		{
			return (DisplayModeParametersKHR*)HeapUtil.AllocateAndClear<DisplayModeParametersKHR>();
		}

		public Extent2D VisibleRegion;

		public uint RefreshRate;
	}

	public unsafe struct DisplayModePropertiesKHR
	{
		public static DisplayModePropertiesKHR* Create()
		{
			return (DisplayModePropertiesKHR*)HeapUtil.AllocateAndClear<DisplayModePropertiesKHR>();
		}

		public DisplayModeKHR DisplayMode;

		public DisplayModeParametersKHR Parameters;
	}

	public unsafe struct DisplayModeCreateInfoKHR
	{
		public static DisplayModeCreateInfoKHR* Create()
		{
			return (DisplayModeCreateInfoKHR*)HeapUtil.AllocateAndClear<DisplayModeCreateInfoKHR>();
		}

		public StructureType SType;

		public void* Next;

		public uint Flags;

		public DisplayModeParametersKHR Parameters;
	}

	public unsafe struct DisplayPlaneCapabilitiesKHR
	{
		public static DisplayPlaneCapabilitiesKHR* Create()
		{
			return (DisplayPlaneCapabilitiesKHR*)HeapUtil.AllocateAndClear<DisplayPlaneCapabilitiesKHR>();
		}

		public uint SupportedAlpha;

		public Offset2D MinSrcPosition;

		public Offset2D MaxSrcPosition;

		public Extent2D MinSrcExtent;

		public Extent2D MaxSrcExtent;

		public Offset2D MinDstPosition;

		public Offset2D MaxDstPosition;

		public Extent2D MinDstExtent;

		public Extent2D MaxDstExtent;
	}

	public unsafe struct DisplayPresentInfoKHR
	{
		public static DisplayPresentInfoKHR* Create()
		{
			return (DisplayPresentInfoKHR*)HeapUtil.AllocateAndClear<DisplayPresentInfoKHR>();
		}

		public StructureType SType;

		public void* Next;

		public Rect2D SrcRect;

		public Rect2D DstRect;

		public Bool32 Persistent;
	}

	public unsafe struct SurfaceCapabilitiesKHR
	{
		public static SurfaceCapabilitiesKHR* Create()
		{
			return (SurfaceCapabilitiesKHR*)HeapUtil.AllocateAndClear<SurfaceCapabilitiesKHR>();
		}

		public uint MinImageCount;

		public uint MaxImageCount;

		public Extent2D CurrentExtent;

		public Extent2D MinImageExtent;

		public Extent2D MaxImageExtent;

		public uint MaxImageArrayLayers;

		public uint SupportedTransforms;

		public SurfaceTransformFlagBitsKHR CurrentTransform;

		public uint SupportedCompositeAlpha;

		public uint SupportedUsageFlags;
	}

	public unsafe struct SurfaceFormatKHR
	{
		public static SurfaceFormatKHR* Create()
		{
			return (SurfaceFormatKHR*)HeapUtil.AllocateAndClear<SurfaceFormatKHR>();
		}

		public Format Format;

		public ColorSpaceKHR ColorSpace;
	}

	public unsafe struct SwapchainCreateInfoKHR
	{
		public static SwapchainCreateInfoKHR* Create()
		{
			return (SwapchainCreateInfoKHR*)HeapUtil.AllocateAndClear<SwapchainCreateInfoKHR>();
		}

		public StructureType SType;

		public void* Next;

		public uint Flags;

		public SurfaceKHR Surface;

		public uint MinImageCount;

		public Format ImageFormat;

		public ColorSpaceKHR ImageColorSpace;

		public Extent2D ImageExtent;

		public uint ImageArrayLayers;

		public uint ImageUsage;

		public SharingMode ImageSharingMode;

		public uint QueueFamilyIndexCount;

		public uint* QueueFamilyIndices;

		public SurfaceTransformFlagBitsKHR PreTransform;

		public CompositeAlphaFlagBitsKHR CompositeAlpha;

		public PresentModeKHR PresentMode;

		public Bool32 Clipped;

		public SwapchainKHR OldSwapchain;
	}

	public unsafe struct PresentInfoKHR
	{
		public static PresentInfoKHR* Create()
		{
			return (PresentInfoKHR*)HeapUtil.AllocateAndClear<PresentInfoKHR>();
		}

		public StructureType SType;

		public void* Next;

		public uint WaitSemaphoreCount;

		public Semaphore* WaitSemaphores;

		public uint SwapchainCount;

		public SwapchainKHR* Swapchains;

		public uint* ImageIndices;

		public Result* Results;
	}

	public unsafe struct DebugReportCallbackCreateInfoEXT
	{
		public static DebugReportCallbackCreateInfoEXT* Create()
		{
			return (DebugReportCallbackCreateInfoEXT*)HeapUtil.AllocateAndClear<DebugReportCallbackCreateInfoEXT>();
		}

		public StructureType SType;

		public void* Next;

		public uint Flags;

		public IntPtr PfnCallback;

		public void* UserData;
	}
}