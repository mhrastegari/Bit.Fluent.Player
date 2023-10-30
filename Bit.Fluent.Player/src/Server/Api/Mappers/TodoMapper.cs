using Riok.Mapperly.Abstractions;
using Bit.Fluent.Player.Server.Api.Models.Todo;
using Bit.Fluent.Player.Shared.Dtos.Todo;

namespace Bit.Fluent.Player.Server.Api.Mappers;

/// <summary>
/// More info at Server/Api/Mappers/README.md
/// </summary>
[Mapper(UseDeepCloning = true)]
public static partial class TodoMapper
{
    public static partial IQueryable<TodoItemDto> Project(this IQueryable<TodoItem> query);
    public static partial TodoItemDto Map(this TodoItem source);
    public static partial TodoItem Map(this TodoItemDto source);
    public static partial void Patch(this TodoItemDto source, TodoItem destination);
}
