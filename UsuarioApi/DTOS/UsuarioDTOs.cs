namespace UsuarioApi.DTOs;

public record CrearUsuarioDto(
    string Nombre,
    string Correo,
    string Telefono
);

public record ActualizarUsuarioDto(
    string Nombre,
    string Correo,
    string Telefono,
    bool Activo
);

public record UsuarioResponseDto(
    int Id,
    string Nombre,
    string Correo,
    string Telefono,
    bool Activo
);