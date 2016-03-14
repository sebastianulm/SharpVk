﻿
using System;
using System.Runtime.InteropServices;

namespace SharpVk.Interop
{
	public static unsafe class NativeMethods
	{
		public const string VulkanDll = "vulkan-1.dll";

		[DllImport(VulkanDll)]
		public static extern Result vkCreateInstance(InstanceCreateInfo* createInfo, AllocationCallbacks* allocator, Instance* instance);

		[DllImport(VulkanDll)]
		public static extern void vkDestroyInstance(Instance instance, AllocationCallbacks* allocator);

		[DllImport(VulkanDll)]
		public static extern Result vkEnumeratePhysicalDevices(Instance instance, uint* physicalDeviceCount, PhysicalDevice* physicalDevices);

		[DllImport(VulkanDll)]
		public static extern IntPtr vkGetDeviceProcAddr(Device device, char* name);

		[DllImport(VulkanDll)]
		public static extern IntPtr vkGetInstanceProcAddr(Instance instance, char* name);

		[DllImport(VulkanDll)]
		public static extern void vkGetPhysicalDeviceProperties(PhysicalDevice physicalDevice, PhysicalDeviceProperties* properties);

		[DllImport(VulkanDll)]
		public static extern void vkGetPhysicalDeviceQueueFamilyProperties(PhysicalDevice physicalDevice, uint* queueFamilyPropertyCount, QueueFamilyProperties* queueFamilyProperties);

		[DllImport(VulkanDll)]
		public static extern void vkGetPhysicalDeviceMemoryProperties(PhysicalDevice physicalDevice, PhysicalDeviceMemoryProperties* memoryProperties);

		[DllImport(VulkanDll)]
		public static extern void vkGetPhysicalDeviceFeatures(PhysicalDevice physicalDevice, PhysicalDeviceFeatures* features);

		[DllImport(VulkanDll)]
		public static extern void vkGetPhysicalDeviceFormatProperties(PhysicalDevice physicalDevice, Format format, FormatProperties* formatProperties);

		[DllImport(VulkanDll)]
		public static extern Result vkGetPhysicalDeviceImageFormatProperties(PhysicalDevice physicalDevice, Format format, ImageType type, ImageTiling tiling, uint usage, uint flags, ImageFormatProperties* imageFormatProperties);

		[DllImport(VulkanDll)]
		public static extern Result vkCreateDevice(PhysicalDevice physicalDevice, DeviceCreateInfo* createInfo, AllocationCallbacks* allocator, Device* device);

		[DllImport(VulkanDll)]
		public static extern void vkDestroyDevice(Device device, AllocationCallbacks* allocator);

		[DllImport(VulkanDll)]
		public static extern Result vkEnumerateInstanceLayerProperties(uint* propertyCount, LayerProperties* properties);

		[DllImport(VulkanDll)]
		public static extern Result vkEnumerateInstanceExtensionProperties(char* layerName, uint* propertyCount, ExtensionProperties* properties);

		[DllImport(VulkanDll)]
		public static extern Result vkEnumerateDeviceLayerProperties(PhysicalDevice physicalDevice, uint* propertyCount, LayerProperties* properties);

		[DllImport(VulkanDll)]
		public static extern Result vkEnumerateDeviceExtensionProperties(PhysicalDevice physicalDevice, char* layerName, uint* propertyCount, ExtensionProperties* properties);

		[DllImport(VulkanDll)]
		public static extern void vkGetDeviceQueue(Device device, uint queueFamilyIndex, uint queueIndex, Queue* queue);

		[DllImport(VulkanDll)]
		public static extern Result vkQueueSubmit(Queue queue, uint submitCount, SubmitInfo* submits, Fence fence);

		[DllImport(VulkanDll)]
		public static extern Result vkQueueWaitIdle(Queue queue);

		[DllImport(VulkanDll)]
		public static extern Result vkDeviceWaitIdle(Device device);

		[DllImport(VulkanDll)]
		public static extern Result vkAllocateMemory(Device device, MemoryAllocateInfo* allocateInfo, AllocationCallbacks* allocator, DeviceMemory* memory);

		[DllImport(VulkanDll)]
		public static extern void vkFreeMemory(Device device, DeviceMemory memory, AllocationCallbacks* allocator);

		[DllImport(VulkanDll)]
		public static extern Result vkMapMemory(Device device, DeviceMemory memory, DeviceSize offset, DeviceSize size, uint flags, void** data);

		[DllImport(VulkanDll)]
		public static extern void vkUnmapMemory(Device device, DeviceMemory memory);

		[DllImport(VulkanDll)]
		public static extern Result vkFlushMappedMemoryRanges(Device device, uint memoryRangeCount, MappedMemoryRange* memoryRanges);

		[DllImport(VulkanDll)]
		public static extern Result vkInvalidateMappedMemoryRanges(Device device, uint memoryRangeCount, MappedMemoryRange* memoryRanges);

		[DllImport(VulkanDll)]
		public static extern void vkGetDeviceMemoryCommitment(Device device, DeviceMemory memory, DeviceSize* committedMemoryInBytes);

		[DllImport(VulkanDll)]
		public static extern void vkGetBufferMemoryRequirements(Device device, Buffer buffer, MemoryRequirements* memoryRequirements);

		[DllImport(VulkanDll)]
		public static extern Result vkBindBufferMemory(Device device, Buffer buffer, DeviceMemory memory, DeviceSize memoryOffset);

		[DllImport(VulkanDll)]
		public static extern void vkGetImageMemoryRequirements(Device device, Image image, MemoryRequirements* memoryRequirements);

		[DllImport(VulkanDll)]
		public static extern Result vkBindImageMemory(Device device, Image image, DeviceMemory memory, DeviceSize memoryOffset);

		[DllImport(VulkanDll)]
		public static extern void vkGetImageSparseMemoryRequirements(Device device, Image image, uint* sparseMemoryRequirementCount, SparseImageMemoryRequirements* sparseMemoryRequirements);

		[DllImport(VulkanDll)]
		public static extern void vkGetPhysicalDeviceSparseImageFormatProperties(PhysicalDevice physicalDevice, Format format, ImageType type, SampleCountFlagBits samples, uint usage, ImageTiling tiling, uint* propertyCount, SparseImageFormatProperties* properties);

		[DllImport(VulkanDll)]
		public static extern Result vkQueueBindSparse(Queue queue, uint bindInfoCount, BindSparseInfo* bindInfo, Fence fence);

		[DllImport(VulkanDll)]
		public static extern Result vkCreateFence(Device device, FenceCreateInfo* createInfo, AllocationCallbacks* allocator, Fence* fence);

		[DllImport(VulkanDll)]
		public static extern void vkDestroyFence(Device device, Fence fence, AllocationCallbacks* allocator);

		[DllImport(VulkanDll)]
		public static extern Result vkResetFences(Device device, uint fenceCount, Fence* fences);

		[DllImport(VulkanDll)]
		public static extern Result vkGetFenceStatus(Device device, Fence fence);

		[DllImport(VulkanDll)]
		public static extern Result vkWaitForFences(Device device, uint fenceCount, Fence* fences, Bool32 waitAll, ulong timeout);

		[DllImport(VulkanDll)]
		public static extern Result vkCreateSemaphore(Device device, SemaphoreCreateInfo* createInfo, AllocationCallbacks* allocator, Semaphore* semaphore);

		[DllImport(VulkanDll)]
		public static extern void vkDestroySemaphore(Device device, Semaphore semaphore, AllocationCallbacks* allocator);

		[DllImport(VulkanDll)]
		public static extern Result vkCreateEvent(Device device, EventCreateInfo* createInfo, AllocationCallbacks* allocator, Event* @event);

		[DllImport(VulkanDll)]
		public static extern void vkDestroyEvent(Device device, Event @event, AllocationCallbacks* allocator);

		[DllImport(VulkanDll)]
		public static extern Result vkGetEventStatus(Device device, Event @event);

		[DllImport(VulkanDll)]
		public static extern Result vkSetEvent(Device device, Event @event);

		[DllImport(VulkanDll)]
		public static extern Result vkResetEvent(Device device, Event @event);

		[DllImport(VulkanDll)]
		public static extern Result vkCreateQueryPool(Device device, QueryPoolCreateInfo* createInfo, AllocationCallbacks* allocator, QueryPool* queryPool);

		[DllImport(VulkanDll)]
		public static extern void vkDestroyQueryPool(Device device, QueryPool queryPool, AllocationCallbacks* allocator);

		[DllImport(VulkanDll)]
		public static extern Result vkGetQueryPoolResults(Device device, QueryPool queryPool, uint firstQuery, uint queryCount, UIntPtr dataSize, void* data, DeviceSize stride, uint flags);

		[DllImport(VulkanDll)]
		public static extern Result vkCreateBuffer(Device device, BufferCreateInfo* createInfo, AllocationCallbacks* allocator, Buffer* buffer);

		[DllImport(VulkanDll)]
		public static extern void vkDestroyBuffer(Device device, Buffer buffer, AllocationCallbacks* allocator);

		[DllImport(VulkanDll)]
		public static extern Result vkCreateBufferView(Device device, BufferViewCreateInfo* createInfo, AllocationCallbacks* allocator, BufferView* view);

		[DllImport(VulkanDll)]
		public static extern void vkDestroyBufferView(Device device, BufferView bufferView, AllocationCallbacks* allocator);

		[DllImport(VulkanDll)]
		public static extern Result vkCreateImage(Device device, ImageCreateInfo* createInfo, AllocationCallbacks* allocator, Image* image);

		[DllImport(VulkanDll)]
		public static extern void vkDestroyImage(Device device, Image image, AllocationCallbacks* allocator);

		[DllImport(VulkanDll)]
		public static extern void vkGetImageSubresourceLayout(Device device, Image image, ImageSubresource* subresource, SubresourceLayout* layout);

		[DllImport(VulkanDll)]
		public static extern Result vkCreateImageView(Device device, ImageViewCreateInfo* createInfo, AllocationCallbacks* allocator, ImageView* view);

		[DllImport(VulkanDll)]
		public static extern void vkDestroyImageView(Device device, ImageView imageView, AllocationCallbacks* allocator);

		[DllImport(VulkanDll)]
		public static extern Result vkCreateShaderModule(Device device, ShaderModuleCreateInfo* createInfo, AllocationCallbacks* allocator, ShaderModule* shaderModule);

		[DllImport(VulkanDll)]
		public static extern void vkDestroyShaderModule(Device device, ShaderModule shaderModule, AllocationCallbacks* allocator);

		[DllImport(VulkanDll)]
		public static extern Result vkCreatePipelineCache(Device device, PipelineCacheCreateInfo* createInfo, AllocationCallbacks* allocator, PipelineCache* pipelineCache);

		[DllImport(VulkanDll)]
		public static extern void vkDestroyPipelineCache(Device device, PipelineCache pipelineCache, AllocationCallbacks* allocator);

		[DllImport(VulkanDll)]
		public static extern Result vkGetPipelineCacheData(Device device, PipelineCache pipelineCache, UIntPtr* dataSize, void* data);

		[DllImport(VulkanDll)]
		public static extern Result vkMergePipelineCaches(Device device, PipelineCache dstCache, uint srcCacheCount, PipelineCache* srcCaches);

		[DllImport(VulkanDll)]
		public static extern Result vkCreateGraphicsPipelines(Device device, PipelineCache pipelineCache, uint createInfoCount, GraphicsPipelineCreateInfo* createInfos, AllocationCallbacks* allocator, Pipeline* pipelines);

		[DllImport(VulkanDll)]
		public static extern Result vkCreateComputePipelines(Device device, PipelineCache pipelineCache, uint createInfoCount, ComputePipelineCreateInfo* createInfos, AllocationCallbacks* allocator, Pipeline* pipelines);

		[DllImport(VulkanDll)]
		public static extern void vkDestroyPipeline(Device device, Pipeline pipeline, AllocationCallbacks* allocator);

		[DllImport(VulkanDll)]
		public static extern Result vkCreatePipelineLayout(Device device, PipelineLayoutCreateInfo* createInfo, AllocationCallbacks* allocator, PipelineLayout* pipelineLayout);

		[DllImport(VulkanDll)]
		public static extern void vkDestroyPipelineLayout(Device device, PipelineLayout pipelineLayout, AllocationCallbacks* allocator);

		[DllImport(VulkanDll)]
		public static extern Result vkCreateSampler(Device device, SamplerCreateInfo* createInfo, AllocationCallbacks* allocator, Sampler* sampler);

		[DllImport(VulkanDll)]
		public static extern void vkDestroySampler(Device device, Sampler sampler, AllocationCallbacks* allocator);

		[DllImport(VulkanDll)]
		public static extern Result vkCreateDescriptorSetLayout(Device device, DescriptorSetLayoutCreateInfo* createInfo, AllocationCallbacks* allocator, DescriptorSetLayout* setLayout);

		[DllImport(VulkanDll)]
		public static extern void vkDestroyDescriptorSetLayout(Device device, DescriptorSetLayout descriptorSetLayout, AllocationCallbacks* allocator);

		[DllImport(VulkanDll)]
		public static extern Result vkCreateDescriptorPool(Device device, DescriptorPoolCreateInfo* createInfo, AllocationCallbacks* allocator, DescriptorPool* descriptorPool);

		[DllImport(VulkanDll)]
		public static extern void vkDestroyDescriptorPool(Device device, DescriptorPool descriptorPool, AllocationCallbacks* allocator);

		[DllImport(VulkanDll)]
		public static extern Result vkResetDescriptorPool(Device device, DescriptorPool descriptorPool, uint flags);

		[DllImport(VulkanDll)]
		public static extern Result vkAllocateDescriptorSets(Device device, DescriptorSetAllocateInfo* allocateInfo, DescriptorSet* descriptorSets);

		[DllImport(VulkanDll)]
		public static extern Result vkFreeDescriptorSets(Device device, DescriptorPool descriptorPool, uint descriptorSetCount, DescriptorSet* descriptorSets);

		[DllImport(VulkanDll)]
		public static extern void vkUpdateDescriptorSets(Device device, uint descriptorWriteCount, WriteDescriptorSet* descriptorWrites, uint descriptorCopyCount, CopyDescriptorSet* descriptorCopies);

		[DllImport(VulkanDll)]
		public static extern Result vkCreateFramebuffer(Device device, FramebufferCreateInfo* createInfo, AllocationCallbacks* allocator, Framebuffer* framebuffer);

		[DllImport(VulkanDll)]
		public static extern void vkDestroyFramebuffer(Device device, Framebuffer framebuffer, AllocationCallbacks* allocator);

		[DllImport(VulkanDll)]
		public static extern Result vkCreateRenderPass(Device device, RenderPassCreateInfo* createInfo, AllocationCallbacks* allocator, RenderPass* renderPass);

		[DllImport(VulkanDll)]
		public static extern void vkDestroyRenderPass(Device device, RenderPass renderPass, AllocationCallbacks* allocator);

		[DllImport(VulkanDll)]
		public static extern void vkGetRenderAreaGranularity(Device device, RenderPass renderPass, Extent2D* granularity);

		[DllImport(VulkanDll)]
		public static extern Result vkCreateCommandPool(Device device, CommandPoolCreateInfo* createInfo, AllocationCallbacks* allocator, CommandPool* commandPool);

		[DllImport(VulkanDll)]
		public static extern void vkDestroyCommandPool(Device device, CommandPool commandPool, AllocationCallbacks* allocator);

		[DllImport(VulkanDll)]
		public static extern Result vkResetCommandPool(Device device, CommandPool commandPool, uint flags);

		[DllImport(VulkanDll)]
		public static extern Result vkAllocateCommandBuffers(Device device, CommandBufferAllocateInfo* allocateInfo, CommandBuffer* commandBuffers);

		[DllImport(VulkanDll)]
		public static extern void vkFreeCommandBuffers(Device device, CommandPool commandPool, uint commandBufferCount, CommandBuffer* commandBuffers);

		[DllImport(VulkanDll)]
		public static extern Result vkBeginCommandBuffer(CommandBuffer commandBuffer, CommandBufferBeginInfo* beginInfo);

		[DllImport(VulkanDll)]
		public static extern Result vkEndCommandBuffer(CommandBuffer commandBuffer);

		[DllImport(VulkanDll)]
		public static extern Result vkResetCommandBuffer(CommandBuffer commandBuffer, uint flags);

		[DllImport(VulkanDll)]
		public static extern void vkCmdBindPipeline(CommandBuffer commandBuffer, PipelineBindPoint pipelineBindPoint, Pipeline pipeline);

		[DllImport(VulkanDll)]
		public static extern void vkCmdSetViewport(CommandBuffer commandBuffer, uint firstViewport, uint viewportCount, Viewport* viewports);

		[DllImport(VulkanDll)]
		public static extern void vkCmdSetScissor(CommandBuffer commandBuffer, uint firstScissor, uint scissorCount, Rect2D* scissors);

		[DllImport(VulkanDll)]
		public static extern void vkCmdSetLineWidth(CommandBuffer commandBuffer, float lineWidth);

		[DllImport(VulkanDll)]
		public static extern void vkCmdSetDepthBias(CommandBuffer commandBuffer, float depthBiasConstantFactor, float depthBiasClamp, float depthBiasSlopeFactor);

		[DllImport(VulkanDll)]
		public static extern void vkCmdSetBlendConstants(CommandBuffer commandBuffer, float blendConstants);

		[DllImport(VulkanDll)]
		public static extern void vkCmdSetDepthBounds(CommandBuffer commandBuffer, float minDepthBounds, float maxDepthBounds);

		[DllImport(VulkanDll)]
		public static extern void vkCmdSetStencilCompareMask(CommandBuffer commandBuffer, uint faceMask, uint compareMask);

		[DllImport(VulkanDll)]
		public static extern void vkCmdSetStencilWriteMask(CommandBuffer commandBuffer, uint faceMask, uint writeMask);

		[DllImport(VulkanDll)]
		public static extern void vkCmdSetStencilReference(CommandBuffer commandBuffer, uint faceMask, uint reference);

		[DllImport(VulkanDll)]
		public static extern void vkCmdBindDescriptorSets(CommandBuffer commandBuffer, PipelineBindPoint pipelineBindPoint, PipelineLayout layout, uint firstSet, uint descriptorSetCount, DescriptorSet* descriptorSets, uint dynamicOffsetCount, uint* dynamicOffsets);

		[DllImport(VulkanDll)]
		public static extern void vkCmdBindIndexBuffer(CommandBuffer commandBuffer, Buffer buffer, DeviceSize offset, IndexType indexType);

		[DllImport(VulkanDll)]
		public static extern void vkCmdBindVertexBuffers(CommandBuffer commandBuffer, uint firstBinding, uint bindingCount, Buffer* buffers, DeviceSize* offsets);

		[DllImport(VulkanDll)]
		public static extern void vkCmdDraw(CommandBuffer commandBuffer, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance);

		[DllImport(VulkanDll)]
		public static extern void vkCmdDrawIndexed(CommandBuffer commandBuffer, uint indexCount, uint instanceCount, uint firstIndex, int vertexOffset, uint firstInstance);

		[DllImport(VulkanDll)]
		public static extern void vkCmdDrawIndirect(CommandBuffer commandBuffer, Buffer buffer, DeviceSize offset, uint drawCount, uint stride);

		[DllImport(VulkanDll)]
		public static extern void vkCmdDrawIndexedIndirect(CommandBuffer commandBuffer, Buffer buffer, DeviceSize offset, uint drawCount, uint stride);

		[DllImport(VulkanDll)]
		public static extern void vkCmdDispatch(CommandBuffer commandBuffer, uint x, uint y, uint z);

		[DllImport(VulkanDll)]
		public static extern void vkCmdDispatchIndirect(CommandBuffer commandBuffer, Buffer buffer, DeviceSize offset);

		[DllImport(VulkanDll)]
		public static extern void vkCmdCopyBuffer(CommandBuffer commandBuffer, Buffer srcBuffer, Buffer dstBuffer, uint regionCount, BufferCopy* regions);

		[DllImport(VulkanDll)]
		public static extern void vkCmdCopyImage(CommandBuffer commandBuffer, Image srcImage, ImageLayout srcImageLayout, Image dstImage, ImageLayout dstImageLayout, uint regionCount, ImageCopy* regions);

		[DllImport(VulkanDll)]
		public static extern void vkCmdBlitImage(CommandBuffer commandBuffer, Image srcImage, ImageLayout srcImageLayout, Image dstImage, ImageLayout dstImageLayout, uint regionCount, ImageBlit* regions, Filter filter);

		[DllImport(VulkanDll)]
		public static extern void vkCmdCopyBufferToImage(CommandBuffer commandBuffer, Buffer srcBuffer, Image dstImage, ImageLayout dstImageLayout, uint regionCount, BufferImageCopy* regions);

		[DllImport(VulkanDll)]
		public static extern void vkCmdCopyImageToBuffer(CommandBuffer commandBuffer, Image srcImage, ImageLayout srcImageLayout, Buffer dstBuffer, uint regionCount, BufferImageCopy* regions);

		[DllImport(VulkanDll)]
		public static extern void vkCmdUpdateBuffer(CommandBuffer commandBuffer, Buffer dstBuffer, DeviceSize dstOffset, DeviceSize dataSize, uint* data);

		[DllImport(VulkanDll)]
		public static extern void vkCmdFillBuffer(CommandBuffer commandBuffer, Buffer dstBuffer, DeviceSize dstOffset, DeviceSize size, uint data);

		[DllImport(VulkanDll)]
		public static extern void vkCmdClearColorImage(CommandBuffer commandBuffer, Image image, ImageLayout imageLayout, ClearColorValue* color, uint rangeCount, ImageSubresourceRange* ranges);

		[DllImport(VulkanDll)]
		public static extern void vkCmdClearDepthStencilImage(CommandBuffer commandBuffer, Image image, ImageLayout imageLayout, ClearDepthStencilValue* depthStencil, uint rangeCount, ImageSubresourceRange* ranges);

		[DllImport(VulkanDll)]
		public static extern void vkCmdClearAttachments(CommandBuffer commandBuffer, uint attachmentCount, ClearAttachment* attachments, uint rectCount, ClearRect* rects);

		[DllImport(VulkanDll)]
		public static extern void vkCmdResolveImage(CommandBuffer commandBuffer, Image srcImage, ImageLayout srcImageLayout, Image dstImage, ImageLayout dstImageLayout, uint regionCount, ImageResolve* regions);

		[DllImport(VulkanDll)]
		public static extern void vkCmdSetEvent(CommandBuffer commandBuffer, Event @event, uint stageMask);

		[DllImport(VulkanDll)]
		public static extern void vkCmdResetEvent(CommandBuffer commandBuffer, Event @event, uint stageMask);

		[DllImport(VulkanDll)]
		public static extern void vkCmdWaitEvents(CommandBuffer commandBuffer, uint eventCount, Event* events, uint srcStageMask, uint dstStageMask, uint memoryBarrierCount, MemoryBarrier* memoryBarriers, uint bufferMemoryBarrierCount, BufferMemoryBarrier* bufferMemoryBarriers, uint imageMemoryBarrierCount, ImageMemoryBarrier* imageMemoryBarriers);

		[DllImport(VulkanDll)]
		public static extern void vkCmdPipelineBarrier(CommandBuffer commandBuffer, uint srcStageMask, uint dstStageMask, uint dependencyFlags, uint memoryBarrierCount, MemoryBarrier* memoryBarriers, uint bufferMemoryBarrierCount, BufferMemoryBarrier* bufferMemoryBarriers, uint imageMemoryBarrierCount, ImageMemoryBarrier* imageMemoryBarriers);

		[DllImport(VulkanDll)]
		public static extern void vkCmdBeginQuery(CommandBuffer commandBuffer, QueryPool queryPool, uint query, uint flags);

		[DllImport(VulkanDll)]
		public static extern void vkCmdEndQuery(CommandBuffer commandBuffer, QueryPool queryPool, uint query);

		[DllImport(VulkanDll)]
		public static extern void vkCmdResetQueryPool(CommandBuffer commandBuffer, QueryPool queryPool, uint firstQuery, uint queryCount);

		[DllImport(VulkanDll)]
		public static extern void vkCmdWriteTimestamp(CommandBuffer commandBuffer, PipelineStageFlagBits pipelineStage, QueryPool queryPool, uint query);

		[DllImport(VulkanDll)]
		public static extern void vkCmdCopyQueryPoolResults(CommandBuffer commandBuffer, QueryPool queryPool, uint firstQuery, uint queryCount, Buffer dstBuffer, DeviceSize dstOffset, DeviceSize stride, uint flags);

		[DllImport(VulkanDll)]
		public static extern void vkCmdPushConstants(CommandBuffer commandBuffer, PipelineLayout layout, uint stageFlags, uint offset, uint size, void* values);

		[DllImport(VulkanDll)]
		public static extern void vkCmdBeginRenderPass(CommandBuffer commandBuffer, RenderPassBeginInfo* renderPassBegin, SubpassContents contents);

		[DllImport(VulkanDll)]
		public static extern void vkCmdNextSubpass(CommandBuffer commandBuffer, SubpassContents contents);

		[DllImport(VulkanDll)]
		public static extern void vkCmdEndRenderPass(CommandBuffer commandBuffer);

		[DllImport(VulkanDll)]
		public static extern void vkCmdExecuteCommands(CommandBuffer commandBuffer, uint commandBufferCount, CommandBuffer* commandBuffers);

		[DllImport(VulkanDll)]
		public static extern Result vkCreateAndroidSurfaceKHR(Instance instance, AllocationCallbacks* allocator, SurfaceKHR* surface);

		[DllImport(VulkanDll)]
		public static extern Result vkGetPhysicalDeviceDisplayPropertiesKHR(PhysicalDevice physicalDevice, uint* propertyCount, DisplayPropertiesKHR* properties);

		[DllImport(VulkanDll)]
		public static extern Result vkGetPhysicalDeviceDisplayPlanePropertiesKHR(PhysicalDevice physicalDevice, uint* propertyCount, DisplayPlanePropertiesKHR* properties);

		[DllImport(VulkanDll)]
		public static extern Result vkGetDisplayPlaneSupportedDisplaysKHR(PhysicalDevice physicalDevice, uint planeIndex, uint* displayCount, DisplayKHR* displays);

		[DllImport(VulkanDll)]
		public static extern Result vkGetDisplayModePropertiesKHR(PhysicalDevice physicalDevice, DisplayKHR display, uint* propertyCount, DisplayModePropertiesKHR* properties);

		[DllImport(VulkanDll)]
		public static extern Result vkCreateDisplayModeKHR(PhysicalDevice physicalDevice, DisplayKHR display, DisplayModeCreateInfoKHR* createInfo, AllocationCallbacks* allocator, DisplayModeKHR* mode);

		[DllImport(VulkanDll)]
		public static extern Result vkGetDisplayPlaneCapabilitiesKHR(PhysicalDevice physicalDevice, DisplayModeKHR mode, uint planeIndex, DisplayPlaneCapabilitiesKHR* capabilities);

		[DllImport(VulkanDll)]
		public static extern Result vkCreateDisplayPlaneSurfaceKHR(Instance instance, AllocationCallbacks* allocator, SurfaceKHR* surface);

		[DllImport(VulkanDll)]
		public static extern Result vkCreateSharedSwapchainsKHR(Device device, uint swapchainCount, SwapchainCreateInfoKHR* createInfos, AllocationCallbacks* allocator, SwapchainKHR* swapchains);

		[DllImport(VulkanDll)]
		public static extern Result vkCreateMirSurfaceKHR(Instance instance, AllocationCallbacks* allocator, SurfaceKHR* surface);

		[DllImport(VulkanDll)]
		public static extern Bool32 vkGetPhysicalDeviceMirPresentationSupportKHR(PhysicalDevice physicalDevice, uint queueFamilyIndex);

		[DllImport(VulkanDll)]
		public static extern void vkDestroySurfaceKHR(Instance instance, SurfaceKHR surface, AllocationCallbacks* allocator);

		[DllImport(VulkanDll)]
		public static extern Result vkGetPhysicalDeviceSurfaceSupportKHR(PhysicalDevice physicalDevice, uint queueFamilyIndex, SurfaceKHR surface, Bool32* supported);

		[DllImport(VulkanDll)]
		public static extern Result vkGetPhysicalDeviceSurfaceCapabilitiesKHR(PhysicalDevice physicalDevice, SurfaceKHR surface, SurfaceCapabilitiesKHR* surfaceCapabilities);

		[DllImport(VulkanDll)]
		public static extern Result vkGetPhysicalDeviceSurfaceFormatsKHR(PhysicalDevice physicalDevice, SurfaceKHR surface, uint* surfaceFormatCount, SurfaceFormatKHR* surfaceFormats);

		[DllImport(VulkanDll)]
		public static extern Result vkGetPhysicalDeviceSurfacePresentModesKHR(PhysicalDevice physicalDevice, SurfaceKHR surface, uint* presentModeCount, PresentModeKHR* presentModes);

		[DllImport(VulkanDll)]
		public static extern Result vkCreateSwapchainKHR(Device device, SwapchainCreateInfoKHR* createInfo, AllocationCallbacks* allocator, SwapchainKHR* swapchain);

		[DllImport(VulkanDll)]
		public static extern void vkDestroySwapchainKHR(Device device, SwapchainKHR swapchain, AllocationCallbacks* allocator);

		[DllImport(VulkanDll)]
		public static extern Result vkGetSwapchainImagesKHR(Device device, SwapchainKHR swapchain, uint* swapchainImageCount, Image* swapchainImages);

		[DllImport(VulkanDll)]
		public static extern Result vkAcquireNextImageKHR(Device device, SwapchainKHR swapchain, ulong timeout, Semaphore semaphore, Fence fence, uint* imageIndex);

		[DllImport(VulkanDll)]
		public static extern Result vkQueuePresentKHR(Queue queue, PresentInfoKHR* presentInfo);

		[DllImport(VulkanDll)]
		public static extern Result vkCreateWaylandSurfaceKHR(Instance instance, AllocationCallbacks* allocator, SurfaceKHR* surface);

		[DllImport(VulkanDll)]
		public static extern Bool32 vkGetPhysicalDeviceWaylandPresentationSupportKHR(PhysicalDevice physicalDevice, uint queueFamilyIndex);

		[DllImport(VulkanDll)]
		public static extern Result vkCreateWin32SurfaceKHR(Instance instance, AllocationCallbacks* allocator, SurfaceKHR* surface);

		[DllImport(VulkanDll)]
		public static extern Bool32 vkGetPhysicalDeviceWin32PresentationSupportKHR(PhysicalDevice physicalDevice, uint queueFamilyIndex);

		[DllImport(VulkanDll)]
		public static extern Result vkCreateXlibSurfaceKHR(Instance instance, AllocationCallbacks* allocator, SurfaceKHR* surface);

		[DllImport(VulkanDll)]
		public static extern Bool32 vkGetPhysicalDeviceXlibPresentationSupportKHR(PhysicalDevice physicalDevice, uint queueFamilyIndex);

		[DllImport(VulkanDll)]
		public static extern Result vkCreateXcbSurfaceKHR(Instance instance, AllocationCallbacks* allocator, SurfaceKHR* surface);

		[DllImport(VulkanDll)]
		public static extern Bool32 vkGetPhysicalDeviceXcbPresentationSupportKHR(PhysicalDevice physicalDevice, uint queueFamilyIndex);

		[DllImport(VulkanDll)]
		public static extern Result vkCreateDebugReportCallbackEXT(Instance instance, DebugReportCallbackCreateInfoEXT* createInfo, AllocationCallbacks* allocator, DebugReportCallbackEXT* callback);

		[DllImport(VulkanDll)]
		public static extern void vkDestroyDebugReportCallbackEXT(Instance instance, DebugReportCallbackEXT callback, AllocationCallbacks* allocator);

		[DllImport(VulkanDll)]
		public static extern void vkDebugReportMessageEXT(Instance instance, uint flags, DebugReportObjectTypeEXT objectType, ulong @object, UIntPtr location, int messageCode, char* layerPrefix, char* message);

	}
}